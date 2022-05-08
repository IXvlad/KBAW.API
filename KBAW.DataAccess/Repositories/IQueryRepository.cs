using System.Linq;
using System.Threading.Tasks;
using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.DataAccess.Repositories
{
    public interface IQueryRepository<TEntity> : ITransient
        where TEntity : class, IEntity
    {
        IQueryable<TEntity> GetAll();
            
        TEntity GetById(long id);

        Task<TEntity> GetByIdAsync(long id);
    }
}