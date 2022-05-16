using KBAW.DataAccess.DomainModels;

namespace KBAW.Command.EFServices.Interfaces
{
    public interface IEntityCommandService<TEntity>
        where TEntity : class, IEntity
    {
        bool Create(TEntity entity);

        bool Update(TEntity entity);

        bool Delete(TEntity entity);
    }
}