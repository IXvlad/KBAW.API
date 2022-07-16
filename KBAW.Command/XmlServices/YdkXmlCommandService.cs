using KBAW.Command.XmlServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices;

public class YdkXmlCommandService : EntityXmlCommandService<Ydk>, IYdkXmlCommandService
{
    public YdkXmlCommandService(IXmlCommandRepository<Ydk> xmlCommandRepository)
        : base(xmlCommandRepository)
    {
        //
    }
}