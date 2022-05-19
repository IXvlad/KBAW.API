using System;
using System.Linq;
using System.Threading.Tasks;
using KBAW.DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace KBAW.DataAccess.Repositories
{
    public class QueryRepository<TEntity> : IQueryRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly string _entityName;
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        private readonly ILogger _logger;

        public QueryRepository(
            ApplicationDbContext dbContext,
            ILoggerFactory factory)
        {
            _entityName = typeof(TEntity).Name;
            _logger = factory.CreateLogger("QueryRepository");
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            _logger.LogInformation("Get all {Entity}.", _entityName);
            return _dbContext.Set<TEntity>();
        }

        public TEntity GetById(long id)
        {
            try
            {
                _logger.LogInformation("Get {Entity} by id: {Id}.", _entityName, id);
                return _dbSet.Find(id);
            }
            catch (Exception exception)
            {
                _logger.LogWarning("Get {Entity} by id: {Id} is failed: {ExceptionMessage}.", _entityName, id, exception.Message);

                return null;
            }
        }

        public async Task<TEntity> GetByIdAsync(long id)
        {
            try
            {
                _logger.LogInformation("Get {Entity} by id: {Id}.", _entityName, id);
                return await _dbSet.FindAsync(id);
            }
            catch (Exception exception)
            {
                _logger.LogWarning("Get {Entity} by id: {Id} is failed: {ExceptionMessage}.", _entityName, id, exception.Message);

                return null;
            }
        }
    }
}