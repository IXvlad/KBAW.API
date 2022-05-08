using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class AuthorsQueryService : EntityQueryService<Author>, IAuthorsQueryService
    {
        public AuthorsQueryService(IQueryRepository<Author> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}