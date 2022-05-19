using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices
{
    public class AuthorOfBookXmlCommandService : EntityXmlCommandService<AuthorOfBook>, IAuthorOfBookXmlCommandService
    {
        public AuthorOfBookXmlCommandService(IXmlCommandRepository<AuthorOfBook> xmlCommandRepository)
            : base(xmlCommandRepository)
        {
            //
        }
    }
}