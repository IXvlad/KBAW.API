using KBAW.Command.EFServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command.EFServices
{
    public class YdkCommandService : EntityCommandService<Ydk>, IYdkCommandService
    {
        public YdkCommandService(ICommandRepository<Ydk> commandRepository)
            : base(commandRepository)
        {
            //
        }
    }
}