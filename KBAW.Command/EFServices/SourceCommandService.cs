using KBAW.Command.EFServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command.EFServices
{
    public class SourceCommandService : EntityCommandService<Source>, ISourceCommandService
    {
        public SourceCommandService(ICommandRepository<Source> commandRepository)
            : base(commandRepository)
        {
            //
        }
    }
}