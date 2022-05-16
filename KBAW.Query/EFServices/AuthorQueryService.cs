using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.EFServices.Interfaces;

namespace KBAW.Query.EFServices
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