using DataAccess.DomainModels;
using KBAW.Container.Dependencies;

namespace KBAW.Query.Interfaces
{
    public interface ISourceQueryService : IEntityQueryService<Source>, IScoped
    {
        //
    }
}