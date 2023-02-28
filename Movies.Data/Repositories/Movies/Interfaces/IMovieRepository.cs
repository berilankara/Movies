using Movies.Data.Base.Repositories.Interfaces;
using Movies.Domain.Entities;

namespace Movies.Data.Repositories.Movies.Interfaces;

public interface IMovieRepository : IRepository<Movie>
{
    /// <summary>
    /// Get movie with relationships by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Movie?> GetWithDetailById(int id);
    
    /// <summary>
    /// Get movies with relationships
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Movie>> GetAllMovies();
}