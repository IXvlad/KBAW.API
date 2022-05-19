using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.EFServices.Interfaces;

namespace KBAW.Query.EFServices
{
    public class ArticleQueryService : EntityQueryService<Article>, IArticleQueryService
    {
        public ArticleQueryService(IQueryRepository<Article> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}