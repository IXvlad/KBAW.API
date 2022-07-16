using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.EFServices.Interfaces;

namespace KBAW.Query.EFServices;

public class EntityQueryService<TEntity> : IEntityQueryService<TEntity>
    where TEntity : class, IEntity
{
    private readonly IQueryRepository<TEntity> _queryRepository;

    public EntityQueryService(IQueryRepository<TEntity> queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public IQueryable<TEntity> GetAll()
    {
        return _queryRepository.GetAll();
    }

    public TEntity GetById(long id)
    {
        return _queryRepository.GetById(id);
    }

    public async Task<TEntity> GetByIdAsync(long id)
    {
        return await _queryRepository.GetByIdAsync(id);
    }
}