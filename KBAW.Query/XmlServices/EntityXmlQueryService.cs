using System.Linq;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices
{
    public class EntityXmlQueryService<TEntity> : IEntityXmlQueryService<TEntity>
        where TEntity : class, IEntity
    {
        private readonly XmlQueryRepository<TEntity> _xmlQueryRepository;

        protected EntityXmlQueryService()
        {
            string name = typeof(TEntity).Name;
            
            _xmlQueryRepository = new XmlQueryRepository<TEntity>(string.Concat(name, ".xml"));
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
}