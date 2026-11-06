using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlow.Tests
{
    public class Calculator_Tests
    {
        [Fact]
        public void Calculate_ShouldReturnSum()
        {
            // Arrange
            double a = 2;
            double b = 3;
            char c = '+';
            Calculator calculator = new Calculator();

            // Act
            var result = calculator.Calculate(a, b, c);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Calculate_ShouldThrowException_ForUnrecognizedCharacter()
        {
            // Arrange
            double a = 2;
            double b = 3;
            char c = '%';
            Calculator calculator = new Calculator();

            // Act


            // Assert
            var exception = Assert.Throws<ArgumentException>(() => calculator.Calculate(a, b, c));
            Assert.Equal($"Operator invalid: {c}",exception.Message);
        }
    }
}
