using DataAccess.DomainModels;
using KBAW.Container.Dependencies;

namespace KBAW.Query.Interfaces
{
    public interface IRecommendedBookQueryService : IEntityQueryService<RecommendedBook>, IScoped
    {
        //
    }
}