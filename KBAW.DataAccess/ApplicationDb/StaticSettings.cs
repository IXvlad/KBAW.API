using Microsoft.Extensions.Configuration;

namespace KBAW.DataAccess.ApplicationDb;

public static class StaticSettings
{
    private const string EnvironmentName = "Development";

    public static DatabaseOptions DatabaseOptions { get; } = new();

    static StaticSettings()
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile($"appsettings.{EnvironmentName}.json", optional: true)
            .Build();

        configuration.GetSection("Database").Bind(DatabaseOptions);
    }
}