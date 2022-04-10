using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.DomainModels;

namespace DomainModels.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IAsyncEnumerable<T>> GetAll();
        
        Task<T> GetById(int id);
        
        Task Create(T item);
        
        Task Update(T item);
        
        Task Delete(T item);
    }
}