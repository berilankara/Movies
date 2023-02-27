using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.Domain.Entities;

namespace Movies.Data.Configurations;

public class GenreEntityTypeConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        #region Base Configuration

        builder.ToTable("Genres");

        #endregion

        #region Property Configuration
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();
        builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.UtcNow);
        builder.Property(x => x.Name).HasMaxLength(150).IsRequired();

        #endregion

        #region Relation Configuration
        
        builder.HasMany(x => x.MovieGenres)
            .WithOne(x => x.Genre)
            .HasForeignKey(x => x.GenreId);
        
        #endregion
    }
}