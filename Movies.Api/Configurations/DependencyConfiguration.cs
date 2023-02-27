using Movies.Application.Services.Genres;
using Movies.Application.Services.Genres.Interfaces;
using Movies.Application.Services.Movies;
using Movies.Application.Services.Movies.Interfaces;
using Movies.Data.Base.Repositories;
using Movies.Data.Base.Repositories.Interfaces;
using Movies.Data.Repositories.Genres;
using Movies.Data.Repositories.Genres.Interfaces;
using Movies.Data.Repositories.Movies;
using Movies.Data.Repositories.Movies.Interfaces;
using Movies.Data.UnitOfWorks;
using Movies.Data.UnitOfWorks.Interfaces;

namespace Movies.Api.Configurations;

public static class DependencyConfiguration
{
    public static void AddDependencyConfiguration(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IMovieRepository, MovieRepository>();
        services.AddScoped<IGenreRepository, GenreRepository>();
        
        services.AddScoped<IMovieService, MovieService>();
        services.AddScoped<IGenreService, GenreService>();
    }
}