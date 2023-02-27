using Movies.Application.Resources.Genres;

namespace Movies.Application.Services.Genres.Interfaces;

public interface IGenreService
{
    // Get genres with name and id
    Task<List<GenreResponse>> GetGenres();
}