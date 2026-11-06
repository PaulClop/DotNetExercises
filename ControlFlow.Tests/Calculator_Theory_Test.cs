using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlow.Tests
{
    public class Calculator_Theory_Test
    {
        [Theory]
        [InlineData(2, 3, '+', 5)]
        [InlineData(7, 3, '-', 4)]
        [InlineData(4, 2, '*', 8)]
        [InlineData(10, 2, '/', 5)]

        public void Calulate_ShouldReturnCorrectResult(double a, double b, char c, double result)
        {
            Calculator calculator = new Calculator();
            double actualResult = calculator.Calculate(a, b, c);

            Assert.Equal(result, actualResult);
        }
    }
}
