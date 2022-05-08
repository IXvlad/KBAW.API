using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class PatentQueryService : EntityQueryService<Patent>, IPatentQueryService
    {
        public PatentQueryService(IQueryRepository<Patent> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}