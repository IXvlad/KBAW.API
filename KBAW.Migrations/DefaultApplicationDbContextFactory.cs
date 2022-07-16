using System;
using System.Collections.Generic;
using KBAW.DataAccess.ApplicationDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace KBAW.Migrations;

public class DefaultApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    private DatabaseOptions _databaseOptions;
    private string _connectionString;
    
    public DefaultApplicationDbContextFactory()
    {
        ConnectionString = StaticSettings.DatabaseOptions.ConnectionStrings["Default"];
    }
    
    public DefaultApplicationDbContextFactory(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }
    
    private string ConnectionString
    {
        get => _connectionString ?? (!_databaseOptions!.ConnectionStrings.TryGetValue("Default", out _connectionString)
            ? throw new InvalidOperationException($"No connection string configured for data source \"Default\"")
            : _connectionString);
        set
        {
            if (_databaseOptions == null)
            {
                _databaseOptions = new DatabaseOptions
                {
                    ConnectionStrings = new Dictionary<string, string>()
                };
            }

            _databaseOptions.ConnectionStrings.Add("Default", value);
        }
    }
    
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var dbContextOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

        ConfigureSqlServer(dbContextOptionsBuilder);

        return new ApplicationDbContext(dbContextOptionsBuilder.Options);
    }

    private static void ConfigureSqlServer(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer(StaticSettings.DatabaseOptions.ConnectionStrings["Default"], cfg =>
        {
            cfg.MigrationsAssembly(typeof(DefaultApplicationDbContextFactory).Assembly.FullName);
        });
    }
}