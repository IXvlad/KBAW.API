using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.EFServices.Interfaces;

namespace KBAW.Query.EFServices
{
    public class AuthorOfBookQueryService : EntityQueryService<AuthorOfBook>, IAuthorOfBookQueryService
    {
        public AuthorOfBookQueryService(IQueryRepository<AuthorOfBook> queryRepository) : base(queryRepository)
        {
            //
        }
    }
}