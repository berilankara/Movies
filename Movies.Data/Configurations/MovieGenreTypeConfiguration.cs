using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.Data.Seeders;
using Movies.Domain.Entities;

namespace Movies.Data.Configurations;

public class MovieGenreTypeConfiguration : IEntityTypeConfiguration<MovieGenre>
{
    public void Configure(EntityTypeBuilder<MovieGenre> builder)
    {
        #region Base Configuration

        builder.ToTable("MovieGenres");

        #endregion

        #region Property Configuration
        
        builder.HasKey(x => new { x.MovieId, x.GenreId });

        #endregion

        #region Relation Configuration
        
        #endregion
        
        #region Seeder Configuration
        
        builder.RegisterSeeder();
        
        #endregion
    }
}