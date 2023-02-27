using Movies.Data.Base.Repositories;
using Movies.Data.Contexts;
using Movies.Data.Repositories.Genres.Interfaces;
using Movies.Domain.Entities;

namespace Movies.Data.Repositories.Genres;

public class GenreRepository : Repository<Genre>, IGenreRepository
{
    public GenreRepository(AppDbContext context) : base(context)
    {
    }
}