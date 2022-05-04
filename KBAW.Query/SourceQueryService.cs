using DataAccess.DomainModels;
using DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class SourceQueryService : EntityQueryService<Source>, ISourceQueryService
    {
        public SourceQueryService(IQueryRepository<Source, long> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}