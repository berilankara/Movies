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

    public async Task<Movie?> GetWithDetailById(int id)
    {
        return await _dbSet
            .Where(x => x.Id == id)
            .Include(x => x.MovieGenres)
            .ThenInclude(x => x.Genre)
            .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Movie>> GetAllMovies()
    {
        return await _dbSet
            .Include(x => x.MovieGenres)
            .ThenInclude(x => x.Genre)       
            .ToListAsync();
    }
}