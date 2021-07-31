using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        //Arrange
         WeatherForecastController  wController = new WeatherForecastController();

        [Fact]
        public void Test1()
        {
            //Act
            var output = wController.FetchData(1);
            //assert
            Assert.Equal("Rachna Singh2",output);
        }
    }
}
