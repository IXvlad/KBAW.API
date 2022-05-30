using System.ComponentModel.DataAnnotations;
using System.Linq;
using KBAW.Utils;
using Xunit;

namespace KBAW.Tests
{
    public class UtilsTest
    {
        [Fact]
        public void ConvertEnumToPropEnum()
        {
            Assert.NotEmpty(EnumHelper.GetListItems<TestEnum>());
            Assert.IsType<PropEnum>(EnumHelper.GetListItems<TestEnum>().FirstOrDefault());
        }

        private enum TestEnum
        {
            [Display(Name = "Test value")] 
            TestValue = 1
        }
    }
}