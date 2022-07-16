using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices;

public class RecommendedBookXmlQueryService : EntityXmlQueryService<RecommendedBook>, IRecommendedBookXmlQueryService
{
    public RecommendedBookXmlQueryService(IXmlQueryRepository<RecommendedBook> xmlQueryRepository)
        : base(xmlQueryRepository)
    {
        //
    }
}