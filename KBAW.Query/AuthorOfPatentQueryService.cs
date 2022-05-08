using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class AuthorOfPatentQueryService : EntityQueryService<AuthorOfPatent>, IAuthorOfPatentQueryService
    {
        public AuthorOfPatentQueryService(IQueryRepository<AuthorOfPatent> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}