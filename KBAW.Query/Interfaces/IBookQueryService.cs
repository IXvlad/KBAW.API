using DataAccess.DomainModels;
using KBAW.Container.Dependencies;
using KBAW.Query.Interfaces;

namespace KBAW.Query
{
    public interface IBookQueryService : IEntityQueryService<Book>, IScoped
    {
        //
    }
}