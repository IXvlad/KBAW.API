using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class AuthorOfArticleQueryService : EntityQueryService<AuthorOfArticle>, IAuthorOfArticleQueryService
    {
        public AuthorOfArticleQueryService(IQueryRepository<AuthorOfArticle> queryRepository) : base(queryRepository)
        {
            //
        }
    }
}