using DataAccess.DomainModels;
using KBAW.Container.Dependencies;

namespace DataAccess.Repositories
{
    public interface ICommandRepository<TEntity> : ITransient
        where TEntity : class, IEntity
    {
        bool Create(TEntity item);
        
        bool Update(TEntity item);
        
        bool Delete(TEntity item);
    }
}