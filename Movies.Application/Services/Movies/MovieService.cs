using AutoMapper;
using Movies.Application.Resources.Movies;
using Movies.Application.Services.Movies.Interfaces;
using Movies.Core.Exceptions;
using Movies.Data.Repositories.Movies.Interfaces;
using Movies.Data.UnitOfWorks.Interfaces;
using Movies.Domain.Entities;

namespace Movies.Application.Services.Movies;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public MovieService(IMovieRepository movieRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _movieRepository = movieRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    /// <summary>
    /// Insert movie
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<int> Insert(MovieInsertRequest request)
    {
        Movie entity = _mapper.Map<Movie>(request);
        
        await _movieRepository.AddAsync(entity);

        var result = await _unitOfWork.SaveChangesAsync();

        if (result <= 0)
            throw new BusinessException("Movie insert error!");

        return entity.Id;
    }

    /// <summary>
    /// Update movie by id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task UpdateById(int id, MovieUpdateRequest request)
    {
        
        Movie? entity = await _movieRepository.GetWithDetailById(id);

        if (entity == null)
            throw new NotFoundException("Movie not found!");

        var updatedEntity = _mapper.Map<MovieUpdateRequest, Movie>(request, entity);
        
        _movieRepository.Update(updatedEntity);

        var result = await _unitOfWork.SaveChangesAsync();

        if (result <= 0)
            throw new BusinessException("Movie update error!");
    }

    /// <summary>
    /// Delete movie by id</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task DeleteById(int id)
    {
        var entity = await _movieRepository.FindAsync(x => x.Id == id);

        if (entity == null)
            throw new NotFoundException("Movie not found!");

        _movieRepository.Remove(entity);

        var result = await _unitOfWork.SaveChangesAsync();

        if (result <= 0)
            throw new BusinessException("Movie delete error!");
    }

    /// <summary>
    /// Get movie by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<MovieResponse> GetById(int id)
    {
        var entity = await _movieRepository.GetWithDetailById(id);

        if (entity == null)
            throw new NotFoundException("Movie not found!");

        return _mapper.Map<MovieResponse>(entity);
    }

    /// <summary>
    /// Get movies
    /// </summary>
    /// <returns></returns>
    public async Task<List<MovieResponse>> GetAll()
    {
        var entity = await _movieRepository.GetAllMovies();

        return _mapper.Map<List<MovieResponse>>(entity.ToList());
    }
}