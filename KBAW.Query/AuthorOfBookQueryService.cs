using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class AuthorOfBookQueryService : EntityQueryService<AuthorOfBook>, IAuthorOfBookQueryService
    {
        public AuthorOfBookQueryService(IQueryRepository<AuthorOfBook> queryRepository) : base(queryRepository)
        {
            //
        }
    }
}