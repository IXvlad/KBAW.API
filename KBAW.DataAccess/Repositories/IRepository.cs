using System.Linq;
using DataAccess.DomainModels;
using KBAW.Container.Dependencies;

namespace DataAccess.Repositories
{
    public interface IRepository<TEntity> : ITransient
        where TEntity : class, IEntity
    {
        IQueryable<TEntity> GetAll();
    }
}