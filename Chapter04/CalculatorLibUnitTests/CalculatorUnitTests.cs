using CalculatorLib;

namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void Add_Adding2and2_ShouldReturn4()
        {
            //Arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            Calculator calc = new();

            //Act
            double actual = calc.Add(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_Adding2and3_ShouldReturn5()
        {
            double a = 2;
            double b = 3;
            double expected = 5;
            Calculator calc = new();
            double actual = calc.Add(a, b);
            Assert.Equal(expected, actual);
        }
    }
}