using DataAccess.DomainModels;
using DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class PatentQueryService : EntityQueryService<Patent>, IPatentQueryService
    {
        public PatentQueryService(IQueryRepository<Patent, long> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}