using Movies.Application.Resources.Genres;

namespace Movies.Application.Resources.Movies;

public class MovieResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<GenreResponse> Genres { get; set; }
    public DateTime ReleaseDate { get; set; }
}