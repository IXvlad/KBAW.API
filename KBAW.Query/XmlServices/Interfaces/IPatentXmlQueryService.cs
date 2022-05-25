﻿using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Query.XmlServices.Interfaces
{
    public interface IPatentXmlQueryService : IEntityXmlQueryService<Patent>, IScoped
    {
        //
    }
}