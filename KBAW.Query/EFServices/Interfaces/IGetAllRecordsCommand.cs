using KBAW.Container.Dependencies;
using KBAW.Query.EFServices.ViewModels;

namespace KBAW.Query.EFServices.Interfaces;

public interface IGetAllRecordsCommand : IScoped
{
    IEnumerable<Record> Get();
}