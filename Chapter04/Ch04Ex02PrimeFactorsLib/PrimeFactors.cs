using System.Text;

namespace Ch04Ex02PrimeFactorsLib
{
    public class PrimeFactors
    {
        public static string? GetPrimeFactors(int number)
        {
            List<string> factors = new();

            //byte divisor = 2;

            //while (divisor <= number)
            //{
            //    if (number % divisor == 0)
            //    {
            //        factors.Add(number);
            //        number /= divisor;
            //    }
            //    divisor++;
            //}

            while (number % 2 == 0)
            {
                factors.Add("2,");
                number /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    factors.Add($"{i},");
                    number /= i;
                }
            }

            if (number > 2)
            {
                factors.Add($"{number},");
            }

            StringBuilder factorsAsString = new();
            for (int i = 0; i < factors.Count; i++)
            {
                factorsAsString.Append(factors[i]);
            }
            return factorsAsString.ToString().Remove(factorsAsString.Length - 1);
        }
    }
}