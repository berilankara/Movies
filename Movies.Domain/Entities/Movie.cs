using Movies.Core;

namespace Movies.Domain.Entities;

public class Movie : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime ReleaseDate { get; set; }

    public virtual ICollection<MovieGenre> MovieGenres { get; set; }
}