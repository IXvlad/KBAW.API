using KBAW.DataAccess.Materials;
using KBAW.DataAccess.Materials.Tables;
using KBAW.ErrorHandler;
using KBAW.Utils;
using Xunit;
using Xunit.Abstractions;

namespace KBAW.Tests
{
    public class McDwWeldingResultTest
    {
        private readonly ITestOutputHelper _output;

        public McDwWeldingResultTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void GetWeldingResult_QualityСonnection()
        {
            string result = WeldabilityCheck.WeldingResult.QualityСonnection.DisplayName();
            Assert.Equal(result, MaterialCombinationDW.GetWeldingResult((int)Materials.AlAlloys, (int)Materials.Cu));
        }

        [Fact]
        public void GetWeldingResult_PoorQualityConnections()
        {
            string result = WeldabilityCheck.WeldingResult.PoorQualityConnections.DisplayName();
            Assert.Equal(result, MaterialCombinationDW.GetWeldingResult((int)Materials.Zr, (int)Materials.Zr));
        }

        [Fact]
        public void GetWeldingResult_NotData()
        {
            string result = WeldabilityCheck.WeldingResult.NotData.DisplayName();
            Assert.Equal(result, MaterialCombinationDW.GetWeldingResult((int)Materials.Mo, (int)Materials.Fe));
        }

        [Fact]
        public void GetWeldingResult_MaterialNotFound()
        {
            Assert.Throws<CustomApplicationException>(
                () => MaterialCombinationDW.GetWeldingResult((int)Materials.Al, (int)Materials.ValveMaterials)
            );

            _output.WriteLine($"Material not found: {Materials.ValveMaterials.ToString()}");
        }
    }
}