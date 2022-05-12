using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Command.Interfaces
{
    public interface IAuthorOfBookCommandService : IEntityCommandService<AuthorOfBook>, IScoped
    {
        //
    }
}