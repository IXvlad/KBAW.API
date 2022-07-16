using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices;

public class EntityXmlQueryService<TEntity> : IEntityXmlQueryService<TEntity>
    where TEntity : class, IEntity
{
    private readonly IXmlQueryRepository<TEntity> _xmlQueryRepository;

    public EntityXmlQueryService(IXmlQueryRepository<TEntity> xmlQueryRepository)
    {
        _xmlQueryRepository = xmlQueryRepository;
    }

    public IQueryable<TEntity> GetAll()
    {
        return _xmlQueryRepository.GetAll();
    }

    public TEntity GetById(long id)
    {
        return _xmlQueryRepository.GetById(id);
    }
}