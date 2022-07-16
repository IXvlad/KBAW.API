using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.DataAccess.XmlRepository;

public interface IXmlCommandRepository<TEntity> : ITransient
    where TEntity : class, IEntity
{
    bool Create(TEntity item);

    bool Update(TEntity item);

    bool Delete(long id);
}