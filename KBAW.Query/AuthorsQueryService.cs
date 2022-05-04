using DataAccess.DomainModels;
using DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class AuthorsQueryService : EntityQueryService<Author>, IAuthorsQueryService
    {
        public AuthorsQueryService(IQueryRepository<Author, long> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}