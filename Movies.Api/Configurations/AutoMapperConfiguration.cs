using System.Reflection;

namespace Movies.Api.Configurations;

public static class AutoMapperConfiguration
{
    public static void AddAutoMappersDynamic(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.Load("Movies.Application"));
    }
}