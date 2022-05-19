using System;
using System.Collections.Generic;
using System.Linq;
using KBAW.DataAccess.DomainModels;
using Microsoft.Extensions.Logging;

namespace KBAW.DataAccess.XmlRepository
{
    public class XmlQueryRepository<TEntity> : IXmlQueryRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly string _entityName;
        private readonly XmlSet<TEntity> _context;
        private readonly ILogger _logger;

        public XmlQueryRepository(ILoggerFactory factory)
        {
            _entityName = typeof(TEntity).Name;
            _logger = factory.CreateLogger("XmlQueryRepository");
            _context = new XmlSet<TEntity>(_entityName + ".xml");
        }
        
        public IQueryable<TEntity> GetAll()
        {
            _logger.LogInformation("Get all {Entity}.", _entityName);
            return _context.Data.AsQueryable();
        }

        public TEntity GetById(long id)
        {
            try
            {
                _logger.LogInformation("Get {Entity} by id: {id}.", _entityName, id);
                IEnumerable<IEntity> items = _context.Data;
                return items.FirstOrDefault(entity => entity.Id.Equals(id)) as TEntity;
            }
            catch (Exception exception)
            {
                _logger.LogWarning("{Entity} with id: {Id} not found: {ExceptionMessage}.", _entityName, id, exception.Message);
                return null;
            }
        }
    }
}