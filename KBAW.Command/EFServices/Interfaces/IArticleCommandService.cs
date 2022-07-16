﻿using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Command.EFServices.Interfaces;

public interface IArticleCommandService : IEntityCommandService<Article>, IScoped
{
    //
}