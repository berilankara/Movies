using Movies.Application.Resources.Movies;

namespace Movies.Application.Services.Movies.Interfaces;

public interface IMovieService
{
    /// <summary>
    /// Insert movie
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<int> Insert(MovieInsertRequest request);

    /// <summary>
    /// Update movie by id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task UpdateById(int id, MovieUpdateRequest request);

    /// <summary>
    /// Delete movie by id</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteById(int id);

    /// <summary>
    /// Get movie by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<MovieResponse> GetById(int id);

    /// <summary>
    /// Get movies
    /// </summary>
    /// <returns></returns>
    Task<List<MovieResponse>> GetAll();
}