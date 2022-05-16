using KBAW.Command.EFServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command.EFServices
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