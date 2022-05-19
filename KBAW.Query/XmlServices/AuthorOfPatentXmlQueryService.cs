using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices
{
    public class AuthorOfPatentXmlQueryService : EntityXmlQueryService<AuthorOfPatent>, IAuthorOfPatentXmlQueryService
    {
        public AuthorOfPatentXmlQueryService(IXmlQueryRepository<AuthorOfPatent> xmlQueryRepository) 
            : base(xmlQueryRepository)
        {
            //
        }
    }
}