using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.XmlRepository;
using KBAW.Query.XmlServices.Interfaces;

namespace KBAW.Query.XmlServices
{
    public class AuthorXmlQueryService : EntityXmlQueryService<Author>, IAuthorXmlQueryService
    {
        public AuthorXmlQueryService(IXmlQueryRepository<Author> xmlQueryRepository) 
            : base(xmlQueryRepository)
        {
            //
        }
    }
}