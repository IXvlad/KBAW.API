using KBAW.Command.XmlServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices;

public class AuthorOfPatentXmlCommandService : EntityXmlCommandService<AuthorOfPatent>, IAuthorOfPatentXmlCommandService
{
    public AuthorOfPatentXmlCommandService(IXmlCommandRepository<AuthorOfPatent> xmlCommandRepository)
        : base(xmlCommandRepository)
    {
        //
    }
}