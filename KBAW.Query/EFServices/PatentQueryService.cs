using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.EFServices.Interfaces;

namespace KBAW.Query.EFServices;

public class PatentQueryService : EntityQueryService<Patent>, IPatentQueryService
{
    public PatentQueryService(IQueryRepository<Patent> queryRepository)
        : base(queryRepository)
    {
        //
    }
}