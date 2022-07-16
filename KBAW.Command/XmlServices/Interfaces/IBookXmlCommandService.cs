using KBAW.Container.Dependencies;
using KBAW.DataAccess.DomainModels;

namespace KBAW.Command.XmlServices.Interfaces;

public interface IBookXmlCommandService : IEntityXmlCommandService<Book>, IScoped
{
    //
}