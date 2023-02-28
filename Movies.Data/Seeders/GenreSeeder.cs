using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.Domain.Entities;

namespace Movies.Data.Seeders;

public static class GenreSeeder 
{
    public static void RegisterSeeder(this EntityTypeBuilder<Genre> builder)
    {
        builder.HasData(
            new Genre { Id = 1, Name = "Crime" },
            new Genre { Id = 2, Name = "Drama" },
            new Genre { Id = 3, Name = "Biography" },
            new Genre { Id = 4, Name = "History" },
            new Genre { Id = 5, Name = "Comedy" },
            new Genre { Id = 6, Name = "Romance" },
            new Genre { Id = 7, Name = "Adventure" },
            new Genre { Id = 8, Name = "Western" },
            new Genre { Id = 9, Name = "Action" }
        );
    }
}