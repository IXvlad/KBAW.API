using KBAW.DataAccess.DomainModels;

namespace KBAW.Command.XmlServices.Interfaces;

public interface IEntityXmlCommandService<TEntity>
    where TEntity : class, IEntity
{
    bool Create(TEntity entity);

    bool Update(TEntity entity);

    bool Delete(long id);
}