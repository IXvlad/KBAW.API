using System.Linq;
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
        
        public IQueryable<TEntity> GetAll() => _dbSet.AsNoTracking();
        
        public TEntity GetById(int id) => _dbSet.Find(id);

        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChangesAsync();
        }
        
        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        
        public void Delete(TEntity item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
    }
}