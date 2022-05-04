using System.Linq;
using System.Threading.Tasks;
using DataAccess.DomainModels;
using DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public abstract class EntityQueryService<TEntity, TKey> : IEntityQueryService<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        private readonly IQueryRepository<TEntity, TKey> _queryRepository;

        protected EntityQueryService(IQueryRepository<TEntity, TKey> queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _queryRepository.GetAll();
        }

        public TEntity GetById(TKey key)
        {
            return _queryRepository.GetById(key);
        }

        public async Task<TEntity> GetByIdAsync(TKey key)
        {
            return await _queryRepository.GetByIdAsync(key);
        }
    }

    public abstract class EntityQueryService<TEntity> : EntityQueryService<TEntity, long>, IEntityQueryService<TEntity>
        where TEntity : class, IEntity<long>
    {
        protected EntityQueryService(IQueryRepository<TEntity, long> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}