using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Command.EFServices.Interfaces
{
    public interface IYdkCommandService: IEntityCommandService<Ydk>, IScoped
    {
        //
    }
}