﻿using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Command.XmlServices
{
    public interface IPatentXmlCommandService : IEntityXmlCommandService<Patent>, IScoped
    {
        //
    }
}