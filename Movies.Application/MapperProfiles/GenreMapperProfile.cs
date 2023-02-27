using AutoMapper;
using Movies.Application.Resources.Genres;
using Movies.Domain.Entities;

namespace Movies.Application.MapperProfiles;

public class GenreMapperProfile : Profile
{
    public GenreMapperProfile()
    {
        CreateMap<Genre, GenreResponse>();
    }
}