using KBAW.Command.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command
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