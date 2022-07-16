using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices;

public class SourceXmlQueryService : EntityXmlQueryService<Source>, ISourceXmlQueryService
{
    public SourceXmlQueryService(IXmlQueryRepository<Source> xmlQueryRepository)
        : base(xmlQueryRepository)
    {
        //
    }
}