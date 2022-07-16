using System;
using KBAW.DataAccess.ApplicationDb;
using KBAW.DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace KBAW.DataAccess.Repositories;

public class CommandRepository<TEntity> : ICommandRepository<TEntity>
    where TEntity : class, IEntity
{
    private readonly string _entityName;
    private readonly ApplicationDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;
    private readonly ILogger _logger;

    public CommandRepository(
        ApplicationDbContext dbContext,
        ILoggerFactory factory)
    {
        _entityName = typeof(TEntity).Name;
        _logger = factory.CreateLogger("CommandRepository");
        _dbContext = dbContext;
        _dbSet = dbContext.Set<TEntity>();
    }

    public bool Create(TEntity item)
    {
        try
        {
            _logger.LogInformation("Create new {Entity}.", _entityName);
            _dbSet.Add(item);
            _dbContext.SaveChanges();

            return true;
        }
        catch (Exception exception)
        {
            _logger.LogWarning("Create new {Entity} is failed: {ExceptionMessage}.", _entityName, exception.Message);

            return false;
        }
    }

    public bool Update(TEntity item)
    {
        try
        {
            _logger.LogInformation("Update {Entity}.", _entityName);
            _dbContext.Entry(item).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return true;
        }
        catch (Exception exception)
        {
            _logger.LogWarning("Update {Entity} is failed: {ExceptionMessage}.", _entityName, exception.Message);

            return false;
        }
    }

    public bool Delete(TEntity item)
    {
        try
        {
            _logger.LogInformation("Delete {Entity}.", _entityName);
            _dbSet.Remove(item);
            _dbContext.SaveChanges();

            return true;
        }
        catch (Exception exception)
        {
            _logger.LogWarning("Delete {Entity} is failed: {ExceptionMessage}.", _entityName, exception.Message);

            return false;
        }
    }
}