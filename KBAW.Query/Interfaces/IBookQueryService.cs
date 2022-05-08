using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public interface IBookQueryService : IEntityQueryService<Book>, IScoped
    {
        //
    }
}