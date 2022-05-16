using System;
using System.Collections.Generic;
using System.Linq;
using KBAW.DataAccess.DomainModels;

namespace KBAW.DataAccess.XmlRepository
{
    public class XmlQueryRepository<TEntity> : IXmlQueryRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly XmlSet<TEntity> _context;

        public XmlQueryRepository(string fileName)
        {
            _context = new XmlSet<TEntity>(fileName);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Data.AsQueryable();
        }

        public TEntity GetById(long id)
        {
            try
            {
                IEnumerable<IEntity> items = _context.Data;
                return items.FirstOrDefault(entity => entity.Id.Equals(id)) as TEntity;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}