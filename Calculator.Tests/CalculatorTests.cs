using Calculator.models;
using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact(DisplayName = "Test der Addition")]
        public void TestAddition()
        {
            Calculator.models.Calculator calc = new models.Calculator();
            decimal result = calc.Calculate(1.5m,3.5m,models.CalculationType.ADDITION);
            Assert.Equal(5.0m, result);
        }
        [Fact(DisplayName = "Test der Subtraktion")]
        public void TestSubtraction()
        {
            Calculator.models.Calculator calc = new models.Calculator();
            decimal result = calc.Calculate(1.5m, 3.5m, models.CalculationType.SUBTRACTION);
            Assert.Equal(-2.0m, result);
        }
        [Fact(DisplayName = "Test der Division")]
        public void TestDivision()
        {
            Assert.Throws<DivideByZeroException>(DivisionByZero);
        }

        internal void DivisionByZero()
        {
            Calculator.models.Calculator calc = new models.Calculator();
            calc.Calculate(5.0m, 0m, models.CalculationType.DIVISTION);
        }

        [Fact(DisplayName = "Test der Subtraktion")]
        public void TestMultiplication()
        {
            Calculator.models.Calculator calc = new models.Calculator();
            decimal result = calc.Calculate(1.5m, 3.5m, models.CalculationType.MULTIPLICATION);
            Assert.Equal(5.25m, result);
        }
    }
}
