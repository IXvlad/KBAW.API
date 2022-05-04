using System.Threading.Tasks;
using DataAccess.DomainModels;

namespace DataAccess.Repositories
{
    public interface IQueryRepository<TEntity, TKey> : IRepository<TEntity>
        where TEntity : class, IEntity<TKey>
    {
        TEntity GetById(TKey key);

        Task<TEntity> GetByIdAsync(TKey key);
    }

    public interface IQueryRepository<TEntity> : IQueryRepository<TEntity, long>
        where TEntity : class, IEntity<long>
    {
        //
    }
}