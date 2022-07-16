using KBAW.Command.EFServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command.EFServices;

public class AuthorOfBookCommandService : EntityCommandService<AuthorOfBook>, IAuthorOfBookCommandService
{
    public AuthorOfBookCommandService(ICommandRepository<AuthorOfBook> commandRepository)
        : base(commandRepository)
    {
        //
    }
}