using Movies.Data.Base.Repositories.Interfaces;
using Movies.Domain.Entities;

namespace Movies.Data.Repositories.Movies.Interfaces;

public interface IMovieRepository : IRepository<Movie>
{
    Task<Movie?> GetWithDetailById(int id);
    Task<IEnumerable<Movie>> GetAllMovies();
}