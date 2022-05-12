using KBAW.Command.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command
{
    public class BookCommandService : EntityCommandService<Book>, IBookCommandService
    {
        public BookCommandService(ICommandRepository<Book> commandRepository)
            : base(commandRepository)
        {
            //
        }
    }
}