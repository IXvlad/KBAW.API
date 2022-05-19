using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices
{
    public class EntityXmlCommandService<TEntity> : IEntityXmlCommandService<TEntity>
        where TEntity : class, IEntity
    {
        private readonly IXmlCommandRepository<TEntity> _xmlCommandRepository;

        public EntityXmlCommandService(IXmlCommandRepository<TEntity> xmlCommandRepository)
        {
            _xmlCommandRepository = xmlCommandRepository;
        }

        public bool Create(TEntity entity)
        {
            return _xmlCommandRepository.Create(entity);
        }

        public bool Update(TEntity entity)
        {
            return _xmlCommandRepository.Update(entity);
        }

        public bool Delete(long id)
        {
            return _xmlCommandRepository.Delete(id);
        }
    }
}