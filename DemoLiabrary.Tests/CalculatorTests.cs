using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLiabrary;
using DemoLibrary;
using Xunit;

namespace DemoLiabrary.Tests
{
    
    public class CalculatorTests
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            //Arrange
            double expected = 5;
            //Act
            double actual = Calculator.Add(3, 2);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
