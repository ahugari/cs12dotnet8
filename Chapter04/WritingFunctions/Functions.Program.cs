using System.Globalization;

internal partial class Program
{
    private static void Timestable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows.");
        WriteLine();
        for (int i = 1; i <= size; i++)
        {
            Console.WriteLine($"{i} x {number} = {i * number}");
        }
        WriteLine();
    }

    private static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        if (twoLetterRegionCode.Trim().Length == 0)
        {
            throw new ArgumentException("Region Code cannot be empty.");
        }
        twoLetterRegionCode = twoLetterRegionCode.ToUpper().Trim();

        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M,
            "DK" or "NO" => 0.25M,
            "GB" or "FR" => 0.2M,
            "HU" => 0.27m,
            "OR" or "AK" or "MT" => 0.0M,
            "ND" or "WI" => 0.05M,
            _ => 0.06M
        };
        return amount * rate;
    }

    private static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false)
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");
    }

    private static CultureInfo GetRandomCulture()
    {
        var randomNumber = new Random().Next(2, 50);
        var cultureInfo = CultureInfo.GetCultures(CultureTypes.AllCultures)[randomNumber];
        WriteLine($"Random culture: {cultureInfo}");
        return cultureInfo;
    }

    /// <summary>
    /// Pass an unsigned integer (uint) and it will be converted to its ordinal equivalent.
    /// </summary>
    /// <param name="number">Number as a cardinal value e.g 1,2,3,... and so on.</param>
    /// <returns>Number as ordinal value 1st, 2nd, 3rd and so on.</returns>
    private static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigits = number % 100;
        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th ";

            default:
                uint lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix} ";
        }
    }

    private static void RunCardinalToOrdinal()
    {
        for (uint number = 1; number <= 1500; number++)
        {
            Console.WriteLine($"{CardinalToOrdinal(number)}");
        }
        WriteLine();
    }

    private static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(message: $"The factorial function is defined for non-negative integers only. Input:{number}", paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * Factorial(number - 1);
            }
        }
    }

    private static void RunFactorial()
    {
        for (int i = -2; i <= 15; i++)
        {
            try
            {
                Console.WriteLine($"{i}!= {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"{i}! is too big for a 32-bit Integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }

    private static int FibImperative(uint term)
    {
        if (term == 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else if (term == 1)
        {
            return 0;
        }
        else if (term == 2)
        {
            return 1;
        }
        else
        {
            return FibImperative(term - 1) + FibImperative(term - 2);
        }
    }

    private static void RunFibImperative()
    {
        for (uint i = 1; i <= 30; i++)
        {
            Console.WriteLine("The {0} term of the Fibonacci sequence is {1:N0}",
                arg0: CardinalToOrdinal(i),
                arg1: FibImperative(term: i));
        }
    }

    private static int FibFunctional(uint term)
    {
        return term switch
        {
            0 => throw new ArgumentOutOfRangeException(),
            1 => 0,
            2 => 1,
            _ => FibFunctional(term - 1) + FibFunctional(term - 2)
        };
    }

    private static void RunFibFunctional()
    {
        for (uint i = 1; i <= 30; i++)
        {
            Console.WriteLine("The {0} term of the Fibonacci sequence is {1:N0}", arg0: CardinalToOrdinal(i), arg1: FibFunctional(term: i));
        }
    }
}