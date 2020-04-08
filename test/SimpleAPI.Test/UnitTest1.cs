using SimpleAPI.Controllers;
using System;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void Test1()
        {

            var retVal = controller.Get();
            Assert.NotNull(retVal);
        }

        [Fact]
        public void Test2()
        {
            var retVal = controller.Get(1);
            Assert.Equal("Johnson Dsouza",retVal.Value);
        }

        [Fact]
        public void Test3()
        {
            var retVal = controller.Get(2);
            Assert.Equal("Johnson Joseph Dsouza", retVal.Value);
        }
    }
}
