using DataAccess.DomainModels;
using DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class AuthorOfPatentQueryService : EntityQueryService<AuthorOfPatent>, IAuthorOfPatentQueryService
    {
        public AuthorOfPatentQueryService(IQueryRepository<AuthorOfPatent, long> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}