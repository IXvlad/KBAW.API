using System.Linq;
using System.Threading.Tasks;
using DataAccess.DomainModels;
using KBAW.Container.Dependencies;

namespace KBAW.Query.Interfaces
{
    public interface IEntityQueryService<TEntity, TKey>
        where TEntity : IEntity<TKey>
    {
        IQueryable<TEntity> GetAll();

        TEntity GetById(TKey key);

        Task<TEntity> GetByIdAsync(TKey key);
    }

    public interface IEntityQueryService<TEntity> : IEntityQueryService<TEntity, long>
        where TEntity : IEntity<long>
    {
        //
    }
}