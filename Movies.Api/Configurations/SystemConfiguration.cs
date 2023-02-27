namespace Movies.Api.Configurations;

public static class SystemConfiguration
{
    public static void AddSystemConfiguration(this ConfigurationManager configurationManager)
    {
        configurationManager
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
            .AddEnvironmentVariables();
    }
}