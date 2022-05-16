using KBAW.Command.EFServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command.EFServices
{
    public class ArticleCommandService : EntityCommandService<Article>, IArticleCommandService
    {
        public ArticleCommandService(ICommandRepository<Article> commandRepository)
            : base(commandRepository)
        {
            //
        }
    }
}