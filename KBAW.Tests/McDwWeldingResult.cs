using KBAW.DataAccess.Materials;
using KBAW.DataAccess.Materials.Tables;
using KBAW.ErrorHandler;
using Xunit;
using Xunit.Abstractions;

namespace KBAW.Tests
{
    public class McDwWeldingResult
    {
        private readonly ITestOutputHelper _output;

        public McDwWeldingResult(ITestOutputHelper output)
        {
            _output = output;
        }
        
        [Fact]
        public void GetWeldingResult_QualityСonnection()
        {
            const WeldabilityCheck.WeldingResult expected = WeldabilityCheck.WeldingResult.QualityСonnection;
            Assert.Equal(expected, MaterialCombinationDW.GetWeldingResult(Materials.AlAlloys, Materials.Cu));
        }

        [Fact]
        public void GetWeldingResult_PoorQualityConnections()
        {
            const WeldabilityCheck.WeldingResult expected = WeldabilityCheck.WeldingResult.PoorQualityConnections;
            Assert.Equal(expected, MaterialCombinationDW.GetWeldingResult(Materials.Zr, Materials.Zr));
        }

        [Fact]
        public void GetWeldingResult_NotData()
        {
            const WeldabilityCheck.WeldingResult expected = WeldabilityCheck.WeldingResult.NotData;
            Assert.Equal(expected, MaterialCombinationDW.GetWeldingResult(Materials.Mo, Materials.Fe));
        }

        [Fact]
        public void GetWeldingResult_MaterialNotFound()
        {
            var exception = Assert.Throws<CustomApplicationException>(
                () => MaterialCombinationDW.GetWeldingResult(Materials.Al, Materials.ValveMaterials)
            );

            Assert.Equal("Material not found in table.", exception.Message);
            Assert.Equal(exception.Detail.FieldName, Materials.ValveMaterials.ToString());
            
            _output.WriteLine($"Material not found: {Materials.ValveMaterials.ToString()}");
        }
    }
}