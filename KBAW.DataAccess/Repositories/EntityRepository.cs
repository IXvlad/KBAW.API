using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainModels.DomainsModel;
using Microsoft.EntityFrameworkCore;

namespace DomainModels.Repositories
{
    public class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public EntityRepository(ApplicationContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        
        public async Task<IAsyncEnumerable<TEntity>> GetAll() => await Task.FromResult(_dbSet.AsAsyncEnumerable());
        
        public async Task<TEntity> GetById(int id) => await _dbSet.FindAsync(id);
        
        public async Task Create(TEntity item)
        {
            _dbSet.Add(item);
            await _context.SaveChangesAsync();
        }
        
        public async Task Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task Delete(TEntity item)
        {
            _dbSet.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}