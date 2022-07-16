using KBAW.Command.XmlServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices;

public class AuthorXmlCommandService : EntityXmlCommandService<Author>, IAuthorXmlCommandService
{
    public AuthorXmlCommandService(IXmlCommandRepository<Author> xmlCommandRepository)
        : base(xmlCommandRepository)
    {
        //
    }
}