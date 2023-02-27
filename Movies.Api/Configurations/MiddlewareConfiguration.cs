using Movies.Core.Middlewares;

namespace Movies.Api.Configurations;

public static class MiddlewareConfiguration
{
    public static IApplicationBuilder UseErrorHandlerMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ErrorHandlerMiddleware>();
    }

    public static void AddErrorHandlerMiddleware(this IServiceCollection services)
    {
        services.AddScoped<ErrorHandlerMiddleware>();
    }
}