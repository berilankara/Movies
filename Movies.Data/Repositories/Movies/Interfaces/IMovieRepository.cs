using Movies.Core.Repositories.Interfaces;
using Movies.Domain.Entities;

namespace Movies.Data.Repositories.MovieRepositories.Interfaces;

public interface IMovieRepository : IRepository<Movie>
{
    Task<Movie?> GetWithDetailById(int id);
    Task<IEnumerable<Movie>> GetAllMovies();
}