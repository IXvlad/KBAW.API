using KBAW.Command.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command
{
    public class AuthorCommandService : EntityCommandService<Author>, IAuthorCommandService
    {
        public AuthorCommandService(ICommandRepository<Author> commandRepository)
            : base(commandRepository)
        {
            //
        }
    }
}