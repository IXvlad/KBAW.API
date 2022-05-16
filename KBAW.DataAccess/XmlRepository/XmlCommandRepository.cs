using System;
using System.Collections.Generic;
using System.Linq;
using KBAW.DataAccess.DomainModels;

namespace KBAW.DataAccess.XmlRepository
{
    public class XmlCommandRepository<TEntity> : IXmlCommandRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly XmlSet<TEntity> _context;

        public XmlCommandRepository(string fileName)
        {
            _context = new XmlSet<TEntity>(fileName);
        }
        
        public bool Create(TEntity item)
        {
            ICollection<TEntity> list = _context.Data;
            list.Add(item);
            _context.Data = list;
            
            return true;
        }

        public bool Update(TEntity item)
        {
            IEntity model = item;
            var items = _context.Data as List<IEntity>;
            
            try
            {
                items?.Remove(items.FirstOrDefault(f => f.Id.Equals(model.Id)));
                items?.Add(model);
                _context.Data = items as ICollection<TEntity>;
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool Delete(long id)
        {
            try
            {
                var items = _context.Data as List<IEntity>;
                items?.Remove(items.First(f => f.Id.Equals(id)));
                _context.Data = items as ICollection<TEntity>;
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}