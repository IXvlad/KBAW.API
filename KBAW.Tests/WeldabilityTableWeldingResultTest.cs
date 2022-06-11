using KBAW.DataAccess.Materials;
using KBAW.DataAccess.Materials.Tables;
using KBAW.ErrorHandler;
using KBAW.Utils;
using Xunit;
using Xunit.Abstractions;

namespace KBAW.Tests
{
    public class WeldabilityTableWeldingResultTest
    {
        private readonly ITestOutputHelper _output;

        public WeldabilityTableWeldingResultTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void GetWeldingResult_QualityСonnection()
        {
            string result = WeldabilityCheck.WeldingResult.QualityСonnection.GetDisplayName();
            Assert.Equal(result, WeldabilityTableMaterials.GetWeldingResult((int)Materials.Al, (int)Materials.ZrAlloys));
        }

        [Fact]
        public void GetWeldingResult_PoorQualityConnections()
        {
            string result = WeldabilityCheck.WeldingResult.PoorQualityConnections.GetDisplayName();
            Assert.Equal(result, WeldabilityTableMaterials.GetWeldingResult((int)Materials.SteelCarbon, (int)Materials.AlAlloys));
        }

        [Fact]
        public void GetWeldingResult_NotData()
        {
            string result = WeldabilityCheck.WeldingResult.NotData.GetDisplayName();
            Assert.Equal(result, WeldabilityTableMaterials.GetWeldingResult((int)Materials.Pb, (int)Materials.Ag));
        }

        [Fact]
        public void GetWeldingResult_MaterialNotFound()
        {
            Assert.Throws<CustomApplicationException>(
                () => WeldabilityTableMaterials.GetWeldingResult((int)Materials.Al, (int)Materials.Columbium)
            );

            _output.WriteLine($"Material not found: {Materials.Columbium.ToString()}");
        }
    }
}