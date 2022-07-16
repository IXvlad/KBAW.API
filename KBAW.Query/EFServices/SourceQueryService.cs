using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.EFServices.Interfaces;

namespace KBAW.Query.EFServices;

public class SourceQueryService : EntityQueryService<Source>, ISourceQueryService
{
    public SourceQueryService(IQueryRepository<Source> queryRepository)
        : base(queryRepository)
    {
        //
    }
}