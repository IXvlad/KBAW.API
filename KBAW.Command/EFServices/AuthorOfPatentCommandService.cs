using KBAW.Command.EFServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command.EFServices
{
    public class AuthorOfPatentCommandService : EntityCommandService<AuthorOfPatent>, IAuthorOfPatentCommandService
    {
        public AuthorOfPatentCommandService(ICommandRepository<AuthorOfPatent> commandRepository)
            : base(commandRepository)
        {
            //
        }
    }
}