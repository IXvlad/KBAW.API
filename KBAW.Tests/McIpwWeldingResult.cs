using KBAW.DataAccess.Materials;
using KBAW.DataAccess.Materials.Tables;
using KBAW.ErrorHandler;
using Xunit;
using Xunit.Abstractions;

namespace KBAW.Tests
{
    public class McIpwWeldingResult
    {
        private readonly ITestOutputHelper _output;

        public McIpwWeldingResult(ITestOutputHelper output)
        {
            _output = output;
        }
        
        [Fact]
        public void GetWeldingResult_QualityСonnection()
        {
            const WeldabilityCheck.WeldingResult expected = WeldabilityCheck.WeldingResult.QualityСonnection;
            Assert.Equal(expected, MaterialCombinationIPW.GetWeldingResult(Materials.TiAlloys, Materials.SteelStainless));
        }
        
        [Fact]
        public void GetWeldingResult_PoorQualityConnections()
        {
            const WeldabilityCheck.WeldingResult expected = WeldabilityCheck.WeldingResult.PoorQualityConnections;
            Assert.Equal(expected, MaterialCombinationIPW.GetWeldingResult(Materials.AlAlloys, Materials.CuZn));
        }
        
        [Fact]
        public void GetWeldingResult_NotData()
        {
            const WeldabilityCheck.WeldingResult expected = WeldabilityCheck.WeldingResult.NotData;
            Assert.Equal(expected, MaterialCombinationIPW.GetWeldingResult(Materials.Bronze, Materials.CarbidesCemented));
        }
        
        [Fact]
        public void GetWeldingResult_MaterialNotFound()
        {
            var exception = Assert.Throws<CustomApplicationException>(
                () => MaterialCombinationIPW.GetWeldingResult(Materials.Al, Materials.FeSintered)
            );

            Assert.Equal("Material not found in table.", exception.Message);
            Assert.Equal(exception.Detail.FieldName, Materials.Al.ToString());
            
            _output.WriteLine($"Material not found: {Materials.Al.ToString()}");
        }
    }
}