using KBAW.Command.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command
{
    public class RecommendedBookCommandService : EntityCommandService<RecommendedBook>, IRecommendedBookCommandService
    {
        public RecommendedBookCommandService(ICommandRepository<RecommendedBook> commandRepository)
            : base(commandRepository)
        {
            //
        }
    }
}