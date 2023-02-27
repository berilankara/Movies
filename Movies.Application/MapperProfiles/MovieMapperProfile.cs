using AutoMapper;
using Movies.Application.Resources;
using Movies.Application.Resources.Movies;
using Movies.Domain.Entities;

namespace Movies.Application.MapperProfiles;

public class MovieMapperProfile : Profile
{
    public MovieMapperProfile()
    {
        CreateMap<Movie, MovieResponse>();
        CreateMap<MovieInsertRequest, Movie>();
        CreateMap<MovieUpdateRequest, Movie>();
    }
}