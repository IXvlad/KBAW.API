using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;
using KBAW.Query.EFServices.Interfaces;

namespace KBAW.Query.EFServices;

public class BookQueryService : EntityQueryService<Book>, IBookQueryService
{
    public BookQueryService(IQueryRepository<Book> queryRepository)
        : base(queryRepository)
    {
        //
    }
}