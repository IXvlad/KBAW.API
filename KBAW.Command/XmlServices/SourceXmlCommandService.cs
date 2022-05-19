using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;

namespace KBAW.Command.XmlServices
{
    public class SourceXmlCommandService : EntityXmlCommandService<Source>, ISourceXmlCommandService
    {
        public SourceXmlCommandService(IXmlCommandRepository<Source> xmlCommandRepository)
            : base(xmlCommandRepository)
        {
            //
        }
    }
}