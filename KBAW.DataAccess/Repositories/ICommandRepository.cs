using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.DataAccess.Repositories
{
    public interface ICommandRepository<TEntity> : ITransient
        where TEntity : class, IEntity
    {
        bool Create(TEntity item);
        
        bool Update(TEntity item);
        
        bool Delete(TEntity item);
    }
}