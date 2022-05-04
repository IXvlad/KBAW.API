using DataAccess.ApplicationDb;
using DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class CommandRepository<TEntity> : ICommandRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public CommandRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }
        
        public bool Create(TEntity item)
        {
            _dbSet.Add(item);
            _dbContext.SaveChanges();

            return true;
        }

        public bool Update(TEntity item)
        {
            _dbContext.Entry(item).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return true;
        }

        public bool Delete(TEntity item)
        {
            _dbSet.Remove(item); 
            _dbContext.SaveChanges();

            return true;
        }
    }
}