using System.Linq;
using System.Threading.Tasks;
using KBAW.DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace KBAW.DataAccess.Repositories
{
    public class QueryRepository<TEntity> : IQueryRepository<TEntity> where TEntity : class, IEntity
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
        
        public TEntity GetById(long id)
        {
            return _dbSet.Find(id);
        }

        public async Task<TEntity> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}