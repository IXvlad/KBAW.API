using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.EFServices.Interfaces;

namespace KBAW.Query.EFServices;

public class AuthorOfPatentQueryService : EntityQueryService<AuthorOfPatent>, IAuthorOfPatentQueryService
{
    public AuthorOfPatentQueryService(IQueryRepository<AuthorOfPatent> queryRepository)
        : base(queryRepository)
    {
        //
    }
}