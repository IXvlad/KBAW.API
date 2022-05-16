using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices
{
    public class EntityXmlCommandService<TEntity> : IEntityXmlCommandService<TEntity>
        where TEntity : class, IEntity
    {
        private readonly XmlCommandRepository<TEntity> _xmlCommandRepository;

        protected EntityXmlCommandService()
        {
            string name = typeof(TEntity).Name;
            
            _xmlCommandRepository = new XmlCommandRepository<TEntity>(string.Concat(name, ".xml"));
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