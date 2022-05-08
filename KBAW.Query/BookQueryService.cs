using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Query
{
    public class BookQueryService : EntityQueryService<Book>, IBookQueryService
    {
        public BookQueryService(IQueryRepository<Book> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}