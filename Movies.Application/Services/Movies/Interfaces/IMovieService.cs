using Movies.Application.Resources;
using Movies.Application.Services.MovieServices.Resources;

namespace Movies.Application.Services.MovieServices.Interfaces;

public interface IMovieService
{
    /// <summary>
    /// Insert movie
    /// </summary>
    /// <param name="request"></param>
    Task<int> Insert(MovieInsertRequest request);
		
    /// <summary>
    /// Update movie by id
    /// </summary>
    /// <param name="request"></param>
    Task UpdateById(int id, MovieUpdateRequest request);
		
    /// <summary>
    /// Delete movie by id
    /// </summary>
    /// <param name="id"></param>
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