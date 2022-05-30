using KBAW.DataAccess.Materials;
using KBAW.DataAccess.Materials.Tables;
using KBAW.ErrorHandler;
using KBAW.Utils;
using Xunit;
using Xunit.Abstractions;

namespace KBAW.Tests
{
    public class McIpwWeldingResultTest
    {
        private readonly ITestOutputHelper _output;

        public McIpwWeldingResultTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void GetWeldingResult_QualityСonnection()
        {
            string result = WeldabilityCheck.WeldingResult.QualityСonnection.DisplayName();
            Assert.Equal(result, MaterialCombinationIPW.GetWeldingResult((int)Materials.TiAlloys, (int)Materials.SteelStainless));
        }

        [Fact]
        public void GetWeldingResult_PoorQualityConnections()
        {
            string result = WeldabilityCheck.WeldingResult.PoorQualityConnections.DisplayName();
            Assert.Equal(result, MaterialCombinationIPW.GetWeldingResult((int)Materials.AlAlloys, (int)Materials.CuZn));
        }

        [Fact]
        public void GetWeldingResult_NotData()
        {
            string result = WeldabilityCheck.WeldingResult.NotData.DisplayName();
            Assert.Equal(result, MaterialCombinationIPW.GetWeldingResult((int)Materials.Bronze, (int)Materials.CarbidesCemented));
        }

        [Fact]
        public void GetWeldingResult_MaterialNotFound()
        {
            Assert.Throws<CustomApplicationException>(
                () => MaterialCombinationIPW.GetWeldingResult((int)Materials.Al, (int)Materials.FeSintered)
            );

            _output.WriteLine($"Material not found: {Materials.Al.ToString()}");
        }
    }
}