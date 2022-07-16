using KBAW.Command.XmlServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices;

public class ArticleXmlCommandService : EntityXmlCommandService<Article>, IArticleXmlCommandService
{
    public ArticleXmlCommandService(IXmlCommandRepository<Article> xmlCommandRepository)
        : base(xmlCommandRepository)
    {
        //
    }
}