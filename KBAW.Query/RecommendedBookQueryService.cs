using DataAccess.DomainModels;
using DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class RecommendedBookQueryService : EntityQueryService<RecommendedBook>, IRecommendedBookQueryService
    {
        public RecommendedBookQueryService(IQueryRepository<RecommendedBook, long> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}