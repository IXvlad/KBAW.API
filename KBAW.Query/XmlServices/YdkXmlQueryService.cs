using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices;

public class YdkXmlQueryService : EntityXmlQueryService<Ydk>, IYdkXmlQueryService
{
    public YdkXmlQueryService(IXmlQueryRepository<Ydk> xmlQueryRepository)
        : base(xmlQueryRepository)
    {
        //
    }
}