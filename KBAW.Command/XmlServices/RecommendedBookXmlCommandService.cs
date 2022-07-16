using KBAW.Command.XmlServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices;

public class RecommendedBookXmlCommandService : EntityXmlCommandService<RecommendedBook>,
    IRecommendedBookXmlCommandService
{
    public RecommendedBookXmlCommandService(IXmlCommandRepository<RecommendedBook> xmlCommandRepository)
        : base(xmlCommandRepository)
    {
        //
    }
}