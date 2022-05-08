using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class SourceQueryService : EntityQueryService<Source>, ISourceQueryService
    {
        public SourceQueryService(IQueryRepository<Source> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}