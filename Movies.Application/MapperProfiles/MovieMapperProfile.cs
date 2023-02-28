using AutoMapper;
using Movies.Application.Resources.Movies;
using Movies.Domain.Entities;

namespace Movies.Application.MapperProfiles;

public class MovieMapperProfile : Profile
{
    public MovieMapperProfile()
    {
        CreateMap<Movie, MovieResponse>()
            .ForMember(x => x.Genres, opt => 
                opt.MapFrom(x => x.MovieGenres.Select(mg => mg.Genre)));
        
        CreateMap<MovieInsertRequest, Movie>()
            .ForMember(x => x.MovieGenres, opt => 
                opt.MapFrom(x => x.GenreIds.Select(x => new MovieGenre { GenreId = x })));
        
        CreateMap<MovieUpdateRequest, Movie>()
            .ForMember(x => x.MovieGenres, opt => 
                opt.MapFrom(x => x.GenreIds.Select(x => new MovieGenre { GenreId = x })));
    }
}