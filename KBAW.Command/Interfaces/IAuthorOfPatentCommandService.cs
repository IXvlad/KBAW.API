using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Command.Interfaces
{
    public interface IAuthorOfPatentCommandService : IEntityCommandService<AuthorOfPatent>, IScoped
    {
        //
    }
}