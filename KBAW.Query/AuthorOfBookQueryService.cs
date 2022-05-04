using DataAccess.DomainModels;
using DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class AuthorOfBookQueryService : EntityQueryService<AuthorOfBook>, IAuthorOfBookQueryService
    {
        public AuthorOfBookQueryService(IQueryRepository<AuthorOfBook, long> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}