using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
        
        #endregion

        #region Relation Configuration

        builder.HasKey(x => new { x.MovieId, x.GenreId });

        #endregion
    }
}