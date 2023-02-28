using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Movies.Application.Resources.Genres;
using Movies.Application.Services.Genres.Interfaces;
using Movies.Data.Repositories.Genres.Interfaces;

namespace Movies.Application.Services.Genres;

public class GenreService : IGenreService
{
    private readonly IGenreRepository _genreRepository;
    private readonly IMapper _mapper;

    public GenreService(IGenreRepository genreRepository, IMapper mapper)
    {
        _genreRepository = genreRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Get genres with name and id
    /// </summary>
    /// <returns></returns>
    public async Task<List<GenreResponse>> GetGenres()
    {
        var entities = await _genreRepository.Query().ToListAsync();

        return _mapper.Map<List<GenreResponse>>(entities);
    }
}