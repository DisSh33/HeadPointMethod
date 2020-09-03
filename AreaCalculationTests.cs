using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HeadPointMethod.Tests
{
    public class AreaCalculationTests
    {
        [Theory]
        [InlineData(0, 7, 8.88, 0)]
        [InlineData(3, 4, 7, 0)]
        [InlineData(-7, 5 , 10 , 0)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(15, 20, 25, 150)]
        public void Area_TestCalculations(double a, double b, double c, double expected)
        {
            var calculation = new AreaCalculation();

            double actual = calculation.Area(a, b, c);

            Assert.Equal(actual, expected);
        }
    }
}
