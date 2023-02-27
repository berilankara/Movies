namespace Movies.Api.Configurations;

public static class CorsConfiguration
{
    public static void AddCorsHeaders(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCors(options => options.AddDefaultPolicy(
            builder => builder.WithOrigins(configuration.GetValue<dynamic>("AllowedHosts"))
        ));
    }

    public static void UseConfiguredCors(this IApplicationBuilder app)
    {
        app.UseCors(options => options
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin());
    }
}