using Microsoft.EntityFrameworkCore;
using Movies.Data.Contexts;

namespace Movies.Api.Configurations;

public static class DatabaseConfiguration
{
    public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(
            options => options.UseSqlServer(configuration.GetValue<string>("MssqlDbSettings:ConnectionString")));

        services.AddScoped<AppDbContext>();
    }
}