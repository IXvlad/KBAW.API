using KBAW.Command.EFServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command.EFServices
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