using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Movies.Api.Configurations;

public static class SwaggerConfiguration
{
    public static void AddConfiguredSwaggerGen(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSwaggerGen(c =>
        {
            var connectionStrings = configuration.GetSection("ConnectionStrings");
            var extensions = new Dictionary<string, IOpenApiExtension>();
            extensions.Add("Database IP", new OpenApiString(connectionStrings["DefaultConnection"]));
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Movies API",
                Description = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") +
                              " - Provides Movies API V1 Version"
            });
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                       Enter 'Bearer' [space] and then your token in the text input below.
                       \r\n\r\nExample: 'Bearer 12345abcdef'",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer"
            });
        });
    }

    public static void UseConfiguredSwagger(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("swagger/v1/swagger.json", "Movies.Api v1");
            c.RoutePrefix = "";
            c.DocExpansion(DocExpansion.None);
        });
    }
}