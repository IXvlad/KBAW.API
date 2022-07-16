using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.EFServices.Interfaces;

namespace KBAW.Query.EFServices;

public class AuthorOfArticleQueryService : EntityQueryService<AuthorOfArticle>, IAuthorOfArticleQueryService
{
    public AuthorOfArticleQueryService(IQueryRepository<AuthorOfArticle> queryRepository)
        : base(queryRepository)
    {
        //
    }
}