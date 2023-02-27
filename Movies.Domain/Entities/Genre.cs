using Movies.Core;

namespace Movies.Domain.Entities;

public class Genre : Entity
{
    public string Name { get; set; }

    public virtual ICollection<MovieGenre> MovieGenres { get; set; }
}