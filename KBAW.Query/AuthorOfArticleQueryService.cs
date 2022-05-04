using DataAccess.DomainModels;
using DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class AuthorOfArticleQueryService : EntityQueryService<AuthorOfArticle>, IAuthorOfArticleQueryService
    {
        public AuthorOfArticleQueryService(IQueryRepository<AuthorOfArticle, long> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}