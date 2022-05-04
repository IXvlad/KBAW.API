using System.Linq;
using System.Threading.Tasks;
using DataAccess.ApplicationDb;
using DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class QueryRepository<TEntity, TKey> : IQueryRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public QueryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }
        
        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }
        
        public TEntity GetById(TKey key)
        {
           return _dbSet.Find(key);
        }

        public async Task<TEntity> GetByIdAsync(TKey key)
        {
            return await _dbSet.FindAsync(key);
        }
    }
}