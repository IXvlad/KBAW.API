using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Query.Interfaces
{
    public interface IAuthorsQueryService : IEntityQueryService<Author>, IScoped
    {
        //
    }
}