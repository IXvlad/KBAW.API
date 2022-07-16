using KBAW.Command.EFServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command.EFServices;

public class AuthorCommandService : EntityCommandService<Author>, IAuthorCommandService
{
    public AuthorCommandService(ICommandRepository<Author> commandRepository)
        : base(commandRepository)
    {
        //
    }
}