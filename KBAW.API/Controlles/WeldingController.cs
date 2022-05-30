using KBAW.DataAccess.Materials.Tables;
using Microsoft.AspNetCore.Mvc;

namespace KBAW.API.Controlles
{
    [ApiController]
    [Route("[controller]")]
    public class WeldingController : ControllerBase
    {
        [HttpGet("GetResultToDW")]
        public string GetResultDW(int materialKey1, int materialKey2)
        {
            return MaterialCombinationDW.GetWeldingResult(materialKey1, materialKey2);
        }

        [HttpGet("GetResultToIPW")]
        public string GetResultIPW(int materialKey1, int materialKey2)
        {
            return MaterialCombinationIPW.GetWeldingResult(materialKey1, materialKey2);
        }

        [HttpGet("GetResultWeldability")]
        public string GetResultWeldability(int materialKey1, int materialKey2)
        {
            return WeldabilityTableMaterials.GetWeldingResult(materialKey1, materialKey2);
        }
    }
}