using System.Linq;
using DomainModels.DomainsModel;

namespace DomainModels.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        IQueryable<T> GetAll();
        
        T GetById(int id);
        
        void Create(T item);
        
        void Update(T item);
        
        void Delete(T item);
    }
}