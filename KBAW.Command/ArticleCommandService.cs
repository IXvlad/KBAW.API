using KBAW.Command.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command
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