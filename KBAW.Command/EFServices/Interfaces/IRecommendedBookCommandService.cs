using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Command.EFServices.Interfaces;

public interface IRecommendedBookCommandService : IEntityCommandService<RecommendedBook>, IScoped
{
    //
}