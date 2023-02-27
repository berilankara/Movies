namespace Movies.Application.Resources;

public class MovieResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<string> GenreName { get; set; }
    public DateTime ReleaseDate { get; set; }
}