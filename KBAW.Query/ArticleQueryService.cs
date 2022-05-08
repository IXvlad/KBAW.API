using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public class ArticleQueryService : EntityQueryService<Article>, IArticleQueryService
    {
        public ArticleQueryService(IQueryRepository<Article> queryRepository) : base(queryRepository)
        {
            //
        }
    }
}