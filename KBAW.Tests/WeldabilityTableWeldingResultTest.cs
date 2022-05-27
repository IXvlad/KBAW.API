using KBAW.DataAccess.Materials;
using KBAW.DataAccess.Materials.Tables;
using KBAW.ErrorHandler;
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
            const WeldabilityCheck.WeldingResult expected = WeldabilityCheck.WeldingResult.QualityСonnection;
            Assert.Equal(expected, WeldabilityTableMaterials.GetWeldingResult(Materials.Al, Materials.ZrAlloys));
        }
        
        [Fact]
        public void GetWeldingResult_PoorQualityConnections()
        {
            const WeldabilityCheck.WeldingResult expected = WeldabilityCheck.WeldingResult.PoorQualityConnections;
            Assert.Equal(expected, WeldabilityTableMaterials.GetWeldingResult(Materials.SteelCarbon, Materials.AlAlloys));
        }
        
        [Fact]
        public void GetWeldingResult_NotData()
        {
            const WeldabilityCheck.WeldingResult expected = WeldabilityCheck.WeldingResult.NotData;
            Assert.Equal(expected, WeldabilityTableMaterials.GetWeldingResult(Materials.Pb, Materials.Ag));
        }
        
        [Fact]
        public void GetWeldingResult_MaterialNotFound()
        {
            var exception = Assert.Throws<CustomApplicationException>(
                () => WeldabilityTableMaterials.GetWeldingResult(Materials.Al, Materials.Columbium)
            );

            Assert.Equal("Material not found in table.", exception.Message);
            Assert.Equal(exception.Detail.FieldName, Materials.Columbium.ToString());
            
            _output.WriteLine($"Material not found: {Materials.Columbium.ToString()}");
        }
    }
}