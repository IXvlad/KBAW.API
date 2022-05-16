using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.EFServices.Interfaces;

namespace KBAW.Query.EFServices
{
    public class YdkQueryService : EntityQueryService<Ydk>, IYdkQueryService
    {
        public YdkQueryService(IQueryRepository<Ydk> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}