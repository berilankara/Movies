using Microsoft.EntityFrameworkCore;
using Movies.Data.Base.Repositories;
using Movies.Data.Contexts;
using Movies.Data.Repositories.Movies.Interfaces;
using Movies.Domain.Entities;

namespace Movies.Data.Repositories.Movies;

public class MovieRepository : Repository<Movie>, IMovieRepository
{
    public MovieRepository(AppDbContext context) : base(context)
    {
    }

    /// <summary>
    /// Get movie with relationships by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Movie?> GetWithDetailById(int id)
    {
        return await _dbSet
            .Where(x => x.Id == id)
            .Include(x => x.MovieGenres)
            .ThenInclude(x => x.Genre)
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Get movies with relationships
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<Movie>> GetAllMovies()
    {
        return await _dbSet
            .Include(x => x.MovieGenres)
            .ThenInclude(x => x.Genre)       
            .ToListAsync();
    }
}