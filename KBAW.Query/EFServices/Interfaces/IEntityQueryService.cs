using System.Linq;
using System.Threading.Tasks;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Query.EFServices.Interfaces
{
    public interface IEntityQueryService<TEntity>
        where TEntity : IEntity
    {
        IQueryable<TEntity> GetAll();

        TEntity GetById(long id);

        Task<TEntity> GetByIdAsync(long id);
    }
}