using System.Linq;
using KBAW.DataAccess.DomainModels;

namespace KBAW.DataAccess.XmlRepository
{
    public interface IXmlQueryRepository<TEntity>
        where TEntity : class, IEntity
    {
        IQueryable<TEntity> GetAll();

        TEntity GetById(long id);
    }
}