using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class AuthorQueryService : EntityQueryService<Author>, IAuthorQueryService
    {
        public AuthorQueryService(IQueryRepository<Author> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}