using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests
{
    public class PrimeFactorsTests
    {
        [Fact]
        public void GetPrimeFactors_WhenNumberIs4_ShouldReturn2and2()
        {
            int number = 4;

            string? primeFactors = PrimeFactors.GetPrimeFactors(number);

            Assert.Equal("2,2", primeFactors?.ToString());
        }

        [Fact]
        public void GetPrimeFactors_WhenNumberIs7_ShouldReturn7()
        {
            int number = 7;

            string? primeFactors = PrimeFactors.GetPrimeFactors(number);

            Assert.Equal("7", primeFactors?.ToString());
        }

        [Fact]
        public void GetPrimeFactors_WhenNumberIs30_ShouldReturn532()
        {
            int number = 30;

            string? primeFactors = PrimeFactors.GetPrimeFactors(number);

            Assert.Equal("2,3,5", primeFactors?.ToString());
        }

        [Fact]
        public void GetPrimeFactors_WhenNumberIs40_ShouldReturn5222()
        {
            int number = 40;

            string? primeFactors = PrimeFactors.GetPrimeFactors(number);

            Assert.Equal("2,2,2,5", primeFactors?.ToString());
        }

        [Fact]
        public void GetPrimeFactors_WhenNumberIs50_ShouldReturn552()
        {
            int number = 50;

            string? primeFactors = PrimeFactors.GetPrimeFactors(number);

            Assert.Equal("2,5,5", primeFactors?.ToString());
        }

        [Fact]
        public void GetPrimeFactors_WhenNumberIs1000_ShouldReturn552()
        {
            int number = 1000;

            string? primeFactors = PrimeFactors.GetPrimeFactors(number);

            Assert.Equal("2,2,2,5,25", primeFactors?.ToString());
        }
    }
}