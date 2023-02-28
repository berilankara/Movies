using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.Domain.Entities;

namespace Movies.Data.Seeders;

public static class MovieGenreSeeder
{
    public static void RegisterSeeder(this EntityTypeBuilder<MovieGenre> builder)
    {
        builder.HasData(
            new MovieGenre { MovieId = 1, GenreId = 1 },
            new MovieGenre { MovieId = 1, GenreId = 2 },
            new MovieGenre { MovieId = 2, GenreId = 2 },
            new MovieGenre { MovieId = 2, GenreId = 3 },
            new MovieGenre { MovieId = 2, GenreId = 4 },
            new MovieGenre { MovieId = 3, GenreId = 1 },
            new MovieGenre { MovieId = 3, GenreId = 2 },
            new MovieGenre { MovieId = 4, GenreId = 2 },
            new MovieGenre { MovieId = 4, GenreId = 5 },
            new MovieGenre { MovieId = 4, GenreId = 6 },
            new MovieGenre { MovieId = 5, GenreId = 7 },
            new MovieGenre { MovieId = 5, GenreId = 8 },
            new MovieGenre { MovieId = 6, GenreId = 2 },
            new MovieGenre { MovieId = 7, GenreId = 2 },
            new MovieGenre { MovieId = 7, GenreId = 3 },
            new MovieGenre { MovieId = 8, GenreId = 2 },
            new MovieGenre { MovieId = 8, GenreId = 9 },
            new MovieGenre { MovieId = 9, GenreId = 2 },
            new MovieGenre { MovieId = 9, GenreId = 3 },
            new MovieGenre { MovieId = 9, GenreId = 5 },
            new MovieGenre { MovieId = 10, GenreId = 2 },
            new MovieGenre { MovieId = 11, GenreId = 2 }
        );
    }
}