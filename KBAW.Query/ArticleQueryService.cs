using DataAccess.DomainModels;
using DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class ArticleQueryService : EntityQueryService<Article>, IArticleQueryService
    {
        public ArticleQueryService(IQueryRepository<Article, long> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}