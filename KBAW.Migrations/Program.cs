using System;
using System.Threading.Tasks;
using KBAW.DataAccess.ApplicationDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

namespace KBAW.Migrations;

public static class Program
{
    private static async Task Main()
    {
        var defaultEfContextFactory = new DefaultApplicationDbContextFactory(StaticSettings.DatabaseOptions);
        var dbContext = defaultEfContextFactory.CreateDbContext(Array.Empty<string>());

        var logger = dbContext.GetService<ILoggerFactory>().CreateLogger(string.Empty);

        try
        {
            await dbContext.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Migration has failed");
            Environment.Exit(-1);
        }
    }
}