namespace Movies.Application.Resources.Movies;

public class MovieUpdateRequest
{
    public List<int> GenreIds { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime ReleaseDate { get; set; }
}