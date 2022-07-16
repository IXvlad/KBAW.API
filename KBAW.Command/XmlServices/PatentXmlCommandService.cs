using KBAW.Command.XmlServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices;

public class PatentXmlCommandService : EntityXmlCommandService<Patent>, IPatentXmlCommandService
{
    public PatentXmlCommandService(IXmlCommandRepository<Patent> xmlCommandRepository)
        : base(xmlCommandRepository)
    {
        //
    }
}