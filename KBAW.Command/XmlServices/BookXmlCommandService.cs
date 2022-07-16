using KBAW.Command.XmlServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices;

public class BookXmlCommandService : EntityXmlCommandService<Book>, IBookXmlCommandService
{
    public BookXmlCommandService(IXmlCommandRepository<Book> xmlCommandRepository)
        : base(xmlCommandRepository)
    {
        //
    }
}