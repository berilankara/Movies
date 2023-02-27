using Movies.Application.Resources;
using Movies.Application.Resources.Movies;

namespace Movies.Application.Services.Movies.Interfaces;

public interface IMovieService
{
    // Insert movie
    Task<int> Insert(MovieInsertRequest request);

    // Update movie by id
    Task UpdateById(int id, MovieUpdateRequest request);

    // Delete movie by id
    Task DeleteById(int id);

    // Get movie by id
    Task<MovieResponse> GetById(int id);

    // Get movies
    Task<List<MovieResponse>> GetAll();
}