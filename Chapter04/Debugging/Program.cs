using static System.Console;

WriteLine("Enter any number..");
string? number = ReadLine();
double c = Double.Parse(number);

#region Exploring debugging lines

double a = 4.5;
double b = 2.5;
double answer = Add(a, b);
WriteLine($"{a} + {b} = {answer}");
WriteLine("Press Enter to end the app.");
ReadLine();

static double Add(double a, double b)
{
    return a + b;
}

#endregion Exploring debugging lines