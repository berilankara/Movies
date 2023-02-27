using System.Text.Json.Serialization;

namespace Movies.Api.Configurations;

public static class ControllerConfiguration
{
    public static void AddControllerConfiguration(this IServiceCollection services)
    {
        services
            .AddControllers()
            .AddJsonOptions(opts =>
            {
                opts.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
        
        services.AddEndpointsApiExplorer();
    }
}