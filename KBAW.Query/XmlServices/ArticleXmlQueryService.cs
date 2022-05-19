using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices
{
    public class ArticleXmlQueryService : EntityXmlQueryService<Article>, IArticleXmlQueryService
    {
        public ArticleXmlQueryService(IXmlQueryRepository<Article> xmlQueryRepository)
            : base(xmlQueryRepository)
        {
            //
        }
    }
}