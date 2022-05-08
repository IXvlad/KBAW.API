using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class RecommendedBookQueryService : EntityQueryService<RecommendedBook>, IRecommendedBookQueryService
    {
        public RecommendedBookQueryService(IQueryRepository<RecommendedBook> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}