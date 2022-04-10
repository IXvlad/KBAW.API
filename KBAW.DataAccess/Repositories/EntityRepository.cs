using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DomainModels.Repositories
{
    public class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public EntityRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }
        
        public async Task<IAsyncEnumerable<TEntity>> GetAll() => await Task.FromResult(_dbSet.AsAsyncEnumerable());
        
        public async Task<TEntity> GetById(int id) => await _dbSet.FindAsync(id);
        
        public async Task Create(TEntity item)
        {
            _dbSet.Add(item);
            await _dbContext.SaveChangesAsync();
        }
        
        public async Task Update(TEntity item)
        {
            _dbContext.Entry(item).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        
        public async Task Delete(TEntity item)
        {
            _dbSet.Remove(item);
            await _dbContext.SaveChangesAsync();
        }
    }
}