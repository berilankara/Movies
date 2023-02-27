namespace Movies.Application.Services.MovieServices.Resources;

public class MovieInsertRequest
{
    public int GenreId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime ReleaseDate { get; set; }
}