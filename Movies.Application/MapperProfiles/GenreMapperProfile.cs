using AutoMapper;
using Movies.Application.Resources.Genres;
using Movies.Application.Resources.MovieGenres;
using Movies.Domain.Entities;

namespace Movies.Application.MapperProfiles;

public class GenreMapperProfile : Profile
{
    public GenreMapperProfile()
    {
        CreateMap<Genre, MovieGenreResponse>();
        CreateMap<Genre, GenreResponse>();
    }
}