using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices;

public class AuthorOfBookXmlQueryService : EntityXmlQueryService<AuthorOfBook>, IAuthorOfBookXmlQueryService
{
    public AuthorOfBookXmlQueryService(IXmlQueryRepository<AuthorOfBook> xmlQueryRepository)
        : base(xmlQueryRepository)
    {
        //
    }
}