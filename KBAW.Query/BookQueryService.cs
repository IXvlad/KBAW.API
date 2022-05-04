using DataAccess.DomainModels;
using DataAccess.Repositories;

namespace KBAW.Query
{
    public class BookQueryService : EntityQueryService<Book>, IBookQueryService
    {
        public BookQueryService(IQueryRepository<Book, long> queryRepository)
            : base(queryRepository)
        {
            //
        }
    }
}