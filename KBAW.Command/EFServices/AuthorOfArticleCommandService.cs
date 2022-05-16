using KBAW.Command.EFServices.Interfaces;
using KBAW.DataAccess.DomainModels;
using KBAW.DataAccess.Repositories;

namespace KBAW.Command.EFServices
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