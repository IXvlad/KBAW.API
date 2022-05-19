using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices
{
    public class AuthorOfArticleXmlCommandService : EntityXmlCommandService<AuthorOfArticle>, IAuthorOfArticleXmlCommandService
    {
        public AuthorOfArticleXmlCommandService(IXmlCommandRepository<AuthorOfArticle> xmlCommandRepository)
            : base(xmlCommandRepository)
        {
            //
        }
    }
}