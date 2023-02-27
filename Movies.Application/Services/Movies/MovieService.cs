using AutoMapper;
using Movies.Application.Resources;
using Movies.Application.Services.MovieServices.Interfaces;
using Movies.Application.Services.MovieServices.Resources;
using Movies.Core.Exceptions;
using Movies.Core.UnitOfWorks.Interfaces;
using Movies.Data.Repositories.Movies.Interfaces;
using Movies.Domain.Entities;

namespace Movies.Application.Services.MovieServices;

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

    public async Task<int> Insert(MovieInsertRequest request)
    {
        Movie entity = _mapper.Map<Movie>(request);
        
        await _movieRepository.AddAsync(entity);

        var result = await _unitOfWork.SaveChangesAsync();

        if (result <= 0)
            throw new BusinessException("Movie insert error!");

        return entity.Id;
    }

    public async Task UpdateById(int id, MovieUpdateRequest request)
    {
        Movie? entity = await _movieRepository.GetWithDetailById(id);
        
        if (entity == null)
            throw new NotFoundException("Movie not found!");

        entity.GenreId = request.GenreId;
        entity.Name = request.Name;
        entity.Description = request.Description;
        entity.ReleaseDate = request.ReleaseDate;
        entity.UpdatedDate = DateTime.UtcNow;

        _movieRepository.Update(entity);
        
        var result = await _unitOfWork.SaveChangesAsync();

        if (result <= 0)
            throw new BusinessException("Movie update error!");
    }

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

    public async Task<MovieResponse> GetById(int id)
    {
        var entity = await _movieRepository.GetWithDetailById(id);

        if (entity == null)
            throw new NotFoundException("Movie not found!");

        return _mapper.Map<MovieResponse>(entity);
    }

    public async Task<List<MovieResponse>> GetAll()
    {
        var entity = await _movieRepository.GetAllMovies();

        return _mapper.Map<List<MovieResponse>>(entity);
    }
}