using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace KBAW.DataAccess.ApplicationDb;

public abstract class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    private readonly DatabaseOptions _databaseOptions;
    
    protected ApplicationDbContextFactory(IOptions<DatabaseOptions> databaseOptions)
    {
        _databaseOptions = databaseOptions.Value;
    }
    
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer(StaticSettings.DatabaseOptions.ConnectionStrings["Default"])
            .UseLazyLoadingProxies();

        return new ApplicationDbContext(builder.Options);
    }
}