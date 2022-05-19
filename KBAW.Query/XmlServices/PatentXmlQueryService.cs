using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices
{
    public class PatentXmlQueryService : EntityXmlQueryService<Patent>, IPatentXmlQueryService
    {
        public PatentXmlQueryService(IXmlQueryRepository<Patent> xmlQueryRepository) 
            : base(xmlQueryRepository)
        {
            //
        }
    }
}