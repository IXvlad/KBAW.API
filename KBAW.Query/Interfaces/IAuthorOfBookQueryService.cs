using DataAccess.DomainModels;
using KBAW.Container.Dependencies;

namespace KBAW.Query.Interfaces
{
    public interface IAuthorOfBookQueryService : IEntityQueryService<AuthorOfBook>, IScoped
    {
        //
    }
}