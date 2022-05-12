using KBAW.Command.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command
{
    public class AuthorOfBookCommandService : EntityCommandService<AuthorOfBook>, IAuthorOfBookCommandService
    {
        public AuthorOfBookCommandService(ICommandRepository<AuthorOfBook> commandRepository)
            : base(commandRepository)
        {
            //
        }
    }
}