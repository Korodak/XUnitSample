namespace Calculator.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Sum_TwoNumbers()
        {
            // Arrange
            var calculator = new XUnitSample.Calculator();

            //act
            var result = calculator.Add(1, 2);

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Subtract_TwoNumbers()
        {
            // Arrange
            var calculator = new XUnitSample.Calculator();

            //act
            var result = calculator.Subtract(1, 2);

            //Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Divide_TwoNumbers()
        {
            // Arrange
            var calculator = new XUnitSample.Calculator();

            //act
            var result = calculator.Divide(1, 2);

            //Assert
            Assert.Equal(0.5M, result);
        }

        [Theory]
        [InlineData(1, 2, 0.5)]
        [InlineData(-10, -2, 5)]
        [InlineData(-2, 1, -2)]        
        public void CanDivide_Theory(int number1, int number2, double expected)
        {
            var calculator = new XUnitSample.Calculator();

            var result = calculator.Divide(number1, number2);

            Assert.Equal((decimal)expected, result);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(-10, 0)]
        [InlineData(-2, 0)]
        public void CannotDivideByZero_Theory(int number1, int number2)
        {
            var calculator = new XUnitSample.Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Divide(number1, number2));
        }
    }
}