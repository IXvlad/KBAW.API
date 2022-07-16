using System.Collections.Generic;
using System.Linq;
using KBAW.DataAccess.Materials;
using KBAW.Utils;
using Microsoft.AspNetCore.Mvc;

namespace KBAW.API.Controlles;

[ApiController]
[Route("[controller]")]
public class MaterialsController : ControllerBase
{
    [HttpGet("GetMaterials")]
    public IEnumerable<PropEnum> GetMaterials()
    {
        return EnumHelper.GetListItems<Materials>().ToList();
    }
}