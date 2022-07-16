using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices;

public class BookXmlQueryService : EntityXmlQueryService<Book>, IBookXmlQueryService
{
    public BookXmlQueryService(IXmlQueryRepository<Book> xmlQueryRepository)
        : base(xmlQueryRepository)
    {
        //
    }
}