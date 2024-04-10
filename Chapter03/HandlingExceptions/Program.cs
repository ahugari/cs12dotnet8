WriteLine("Before parsing:");
Write("What is your age?");
string? input = ReadLine();
try
{
    int age = int.Parse(input!);
    Console.WriteLine($"You are {age} years old.");
}
catch (FormatException) when (input!.Contains("years"))
{
    Console.WriteLine("Your age cannot contain the word 'years'.");
}
catch (FormatException)
{
    Console.WriteLine("The number you entered was not in the correct format.");
}
catch (OverflowException)
{
    Console.WriteLine("Your age is a valid number but it's either too big or too small.");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After parsing:");

#region Exploring handling overflows

try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"Inital value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
    }
}
catch (OverflowException)
{
    Console.WriteLine("The code overflowed and I caught the exception.");
}

unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Inital value: {y}");
    y--;
    WriteLine($"After incrementing: {y}");
    y--;
    WriteLine($"After incrementing: {y}");
    y--;
    WriteLine($"After incrementing: {y}");
}

#endregion Exploring handling overflows