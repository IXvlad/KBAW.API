﻿using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Query.EFServices.Interfaces;

public interface IAuthorOfPatentQueryService : IEntityQueryService<AuthorOfPatent>, IScoped
{
    //
}