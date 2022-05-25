﻿using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Command.XmlServices
{
    public interface IArticleXmlCommandService : IEntityXmlCommandService<Article>, IScoped
    {
        //
    }
}