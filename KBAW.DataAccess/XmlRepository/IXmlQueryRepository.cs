using System.Linq;
using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.DataAccess.XmlRepository;

public interface IXmlQueryRepository<TEntity> : ITransient
    where TEntity : class, IEntity
{
    IQueryable<TEntity> GetAll();

    TEntity GetById(long id);
}