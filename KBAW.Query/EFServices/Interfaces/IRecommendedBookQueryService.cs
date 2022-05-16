using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Query.EFServices.Interfaces
{
    public interface IRecommendedBookQueryService : IEntityQueryService<RecommendedBook>, IScoped
    {
        //
    }
}