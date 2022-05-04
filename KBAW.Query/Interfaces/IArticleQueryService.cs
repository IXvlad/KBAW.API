﻿using DataAccess.DomainModels;
using KBAW.Container.Dependencies;

namespace KBAW.Query.Interfaces
{
    public interface IArticleQueryService : IEntityQueryService<Article>, IScoped
    {
        //
    }
}