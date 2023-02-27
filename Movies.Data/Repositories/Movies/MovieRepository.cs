using Microsoft.EntityFrameworkCore;
using Movies.Core.Repositories;
using Movies.Data.Contexts;
using Movies.Data.Repositories.MovieRepositories.Interfaces;
using Movies.Domain.Entities;

namespace Movies.Data.Repositories.MovieRepositories;

public class MovieRepository : Repository<Movie>, IMovieRepository
{
    public MovieRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Movie?> GetWithDetailById(int id)
    {
        return await _dbSet
            .Where(x => x.Id == id)
            .Include(x => x.Genres)
            .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Movie>> GetAllMovies()
    {
        return await _dbSet
            .Include(x => x.Genres)
            .ToListAsync();
    }
}