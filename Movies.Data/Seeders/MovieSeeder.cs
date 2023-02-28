using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.Domain.Entities;

namespace Movies.Data.Seeders;

public static class MovieSeeder
{
    public static void RegisterSeeder(this EntityTypeBuilder<Movie> builder)
    {
        builder.HasData(
            new Movie { Id = 1, Name = "The Godfather", Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.", ReleaseDate = DateTime.Parse("1973-10-01") },
            new Movie { Id = 2, Name = "Schindler's List", Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", ReleaseDate = DateTime.Parse("1994-03-04") },
            new Movie { Id = 3, Name = "12 Angry Men", Description = "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.", ReleaseDate = DateTime.Parse("1960-04-01") },
            new Movie { Id = 4, Name = "La vita è bella", Description = "When an open-minded Jewish waiter and his son become victims of the Holocaust, he uses a perfect mixture of will, humor, and imagination to protect his son from the dangers around their camp.", ReleaseDate = DateTime.Parse("1999-02-26") }, 
            new Movie { Id = 5, Name = "Il buono, il brutto, il cattivo", Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", ReleaseDate = DateTime.Parse("1969-01-13") },
            new Movie { Id = 6, Name = "The Shawshank Redemption", Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", ReleaseDate = DateTime.Parse("1995-03-10") },
            new Movie { Id = 7, Name = "The Pursuit of Happyness", Description = "A struggling salesman takes custody of his son as he's poised to begin a life-changing professional career.", ReleaseDate = DateTime.Parse("2007-03-02") },
            new Movie { Id = 8, Name = "Shichinin no samurai", Description = "Farmers from a village exploited by bandits hire a veteran samurai for protection, who gathers six other samurai to join him.", ReleaseDate = DateTime.Parse("1954-04-26") },
            new Movie { Id = 9, Name = "Intouchables", Description = "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver.", ReleaseDate = DateTime.Parse("2012-05-11") },
            new Movie { Id = 10, Name = "Central do Brasil", Description = "The emotive journey of a former schoolteacher who writes letters for illiterate people, and a young boy whose mother has just died, as they search for the father he never knew.", ReleaseDate = DateTime.Parse("1999-05-28") },
            new Movie { Id = 11, Name = "Requiem for a Dream", Description = "The drug-induced utopias of four Coney Island people are shattered when their addictions run deep.", ReleaseDate = DateTime.Parse("2000-10-27") }
        );
    }
}