using System.Linq;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Query.XmlServices.Interfaces
{
    public interface IEntityXmlQueryService<TEntity>
        where TEntity : IEntity
    {
        IQueryable<TEntity> GetAll();

        TEntity GetById(long id);
    }
}