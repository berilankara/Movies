using Movies.Application.Resources.Genres;

namespace Movies.Application.Services.Genres.Interfaces;

public interface IGenreService
{
    /// <summary>
    /// Get genres with name and id
    /// </summary>
    /// <returns></returns>
    Task<List<GenreResponse>> GetGenres();
}