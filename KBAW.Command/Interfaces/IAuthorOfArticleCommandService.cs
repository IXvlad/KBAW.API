﻿using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Command.Interfaces
{
    public interface IAuthorOfArticleCommandService : IEntityCommandService<AuthorOfArticle>, IScoped
    {
        //
    }
}