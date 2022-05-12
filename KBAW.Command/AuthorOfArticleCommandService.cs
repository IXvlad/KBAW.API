using KBAW.Command.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command
{
    public class AuthorOfArticleCommandService : EntityCommandService<AuthorOfArticle>, IAuthorOfArticleCommandService
    {
        public AuthorOfArticleCommandService(ICommandRepository<AuthorOfArticle> commandRepository)
            : base(commandRepository)
        {
            //
        }
    }
}