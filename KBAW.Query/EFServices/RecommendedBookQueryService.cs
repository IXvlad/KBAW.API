using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.EFServices.Interfaces;

namespace KBAW.Query.EFServices;

public class RecommendedBookQueryService : EntityQueryService<RecommendedBook>, IRecommendedBookQueryService
{
    public RecommendedBookQueryService(IQueryRepository<RecommendedBook> queryRepository)
        : base(queryRepository)
    {
        //
    }
}