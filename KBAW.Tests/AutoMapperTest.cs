using AutoMapper;
using KBAW.API.Infrastructure;
using Xunit;

namespace KBAW.Tests
{
    public class AutoMapperTest
    {
        [Fact]
        public void MerchantPanelAutoMapper_Configuration_IsValid()
        {
            var config = new MapperConfiguration(m =>
            {
                m.AddProfile<AutoMapperProfile>();
            });

            config.AssertConfigurationIsValid();
        }
    }
}