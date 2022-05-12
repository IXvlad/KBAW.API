using KBAW.Command.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command
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