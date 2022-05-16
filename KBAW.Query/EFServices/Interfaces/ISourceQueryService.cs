using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Query.EFServices.Interfaces
{
    public interface ISourceQueryService : IEntityQueryService<Source>, IScoped
    {
        //
    }
}