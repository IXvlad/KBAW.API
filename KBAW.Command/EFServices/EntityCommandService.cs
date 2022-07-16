using KBAW.Command.EFServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command.EFServices;

public class EntityCommandService<TEntity> : IEntityCommandService<TEntity>
    where TEntity : class, IEntity
{
    private readonly ICommandRepository<TEntity> _commandRepository;

    public EntityCommandService(ICommandRepository<TEntity> commandRepository)
    {
        _commandRepository = commandRepository;
    }

    public bool Create(TEntity entity)
    {
        return _commandRepository.Create(entity);
    }

    public bool Update(TEntity entity)
    {
        return _commandRepository.Update(entity);
    }

    public bool Delete(TEntity entity)
    {
        return _commandRepository.Delete(entity);
    }
}