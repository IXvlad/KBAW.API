using System.Linq;
using System.Threading.Tasks;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public abstract class EntityQueryService<TEntity> : IEntityQueryService<TEntity>
        where TEntity : class, IEntity
    {
        private readonly IQueryRepository<TEntity> _queryRepository;

        protected EntityQueryService(IQueryRepository<TEntity> queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _queryRepository.GetAll();
        }

        public TEntity GetById(long id)
        {
            return _queryRepository.GetById(id);
        }

        public async Task<TEntity> GetByIdAsync(long id)
        {
            return await _queryRepository.GetByIdAsync(id);
        }
    }
}