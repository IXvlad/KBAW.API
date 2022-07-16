using System;
using System.Collections.Generic;
using System.Linq;
using KBAW.DataAccess.DomainModels;
using Microsoft.Extensions.Logging;

namespace KBAW.DataAccess.XmlRepository;

public class XmlCommandRepository<TEntity> : IXmlCommandRepository<TEntity>
    where TEntity : class, IEntity
{
    private readonly string _entityName;
    private readonly XmlSet<TEntity> _context;
    private readonly ILogger _logger;

    public XmlCommandRepository(ILoggerFactory factory)
    {
        _entityName = typeof(TEntity).Name;
        _logger = factory.CreateLogger("XmlCommandRepository");
        _context = new XmlSet<TEntity>(_entityName + ".xml");
    }

    public bool Create(TEntity item)
    {
        try
        {
            _logger.LogInformation("Create new {Entity}.", _entityName);
            ICollection<TEntity> list = _context.Data;
            list.Add(item);
            _context.Data = list;
        }
        catch (Exception exception)
        {
            _logger.LogWarning("Create new {Entity} is failed: {ExceptionMessage}", _entityName, exception.Message);

            return false;
        }

        return true;
    }

    public bool Update(TEntity item)
    {
        IEntity model = item;
        var items = _context.Data as List<IEntity>;

        try
        {
            _logger.LogInformation("Update {Entity}.", _entityName);
            items?.Remove(items.FirstOrDefault(f => f.Id.Equals(model.Id)));
            items?.Add(model);
            _context.Data = items as ICollection<TEntity>;

            return true;
        }
        catch (Exception exception)
        {
            _logger.LogWarning("Update {Entity} is failed: {ExceptionMessage}", _entityName, exception.Message);

            return false;
        }
    }

    public bool Delete(long id)
    {
        try
        {
            _logger.LogInformation("Delete {Entity}.", _entityName);
            var items = _context.Data as List<IEntity>;
            items?.Remove(items.First(f => f.Id.Equals(id)));
            _context.Data = items as ICollection<TEntity>;

            return true;
        }
        catch (Exception exception)
        {
            _logger.LogWarning("Delete {Entity} is failed: {ExceptionMessage}", _entityName, exception.Message);

            return false;
        }
    }
}