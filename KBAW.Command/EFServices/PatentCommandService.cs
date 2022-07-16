using KBAW.Command.EFServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command.EFServices;

public class PatentCommandService : EntityCommandService<Patent>, IPatentCommandService
{
    public PatentCommandService(ICommandRepository<Patent> commandRepository)
        : base(commandRepository)
    {
        //
    }
}