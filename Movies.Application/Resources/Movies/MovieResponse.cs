using Movies.Application.Resources.Genres;
using Movies.Application.Resources.MovieGenres;

namespace Movies.Application.Resources.Movies;

public class MovieResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<MovieGenreResponse> Genres { get; set; }
    public DateTime ReleaseDate { get; set; }
}