using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices;

public class AuthorOfArticleXmlQueryService : EntityXmlQueryService<AuthorOfArticle>,
    IAuthorOfArticleXmlQueryService
{
    public AuthorOfArticleXmlQueryService(IXmlQueryRepository<AuthorOfArticle> xmlQueryRepository)
        : base(xmlQueryRepository)
    {
        //
    }
}