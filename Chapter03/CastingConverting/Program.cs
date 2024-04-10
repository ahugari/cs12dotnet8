using System.Globalization;
using static System.Convert;

int a = 10;
double b = a;
WriteLine($"a is {a:n0} and b is {b:n0}");

double c = 10.8;
int d = (int)c;
WriteLine($"c is {c:n0} and d is {d:n0}");

long e = 5_000_000_000;
int f = (int)e;
WriteLine($"e is {e:n0} and f is {f:n0}");

e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:n0} and f is {f:n0}");

WriteLine("{0,15} {1,35}", "Decimal", "Binary");
WriteLine("{0,15:N0} {0,35:B0}", int.MaxValue);
for (int i = 8; i >= -8; i--)
{
    WriteLine("{0,15:N0} {0,35:B0}", i);
}
WriteLine("{0,15:N0} {0,35:B0}", int.MinValue);

double g = 9.8;
int h = ToInt32(g);

WriteLine($"g is {g} and h is {h}");

double[,] doubles =
{
    {9.49, 9.5, 9.51 },
    {10.49, 10.5, 10.51 },
    {11.49, 11.5, 11.51 },
    {12.49, 12.5, 12.51 },
    {-12.49, -12.5, -12.51 },
    {-11.49, -11.5, -11.51 },
    {-10.49, -10.5, -10.51 },
    {-9.49, -9.5, -9.51 }
};

WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
for (int i = 0; i < 8; i++)
{
    for (int y = 0; y < 3; y++)
    {
        Console.Write($"| {doubles[i, y],6} | {ToInt32(doubles[i, y]),7} ");
    }
    Console.WriteLine("|");
}
WriteLine();

foreach (double x in doubles)
{
    Math.Round(x, 0, MidpointRounding.AwayFromZero);
    Console.WriteLine(format:
        "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        arg0: x,
        arg1: Math.Round(x, 0, MidpointRounding.AwayFromZero));
}

#region Exploring Converting to string

int number = 122;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime dateTime = DateTime.Now;
WriteLine(dateTime.ToString());
object me = new();
WriteLine(me.ToString());

#endregion Exploring Converting to string

#region Exploring converting binary string to an object

byte[] binaryObject = new Byte[128];

Random.Shared.NextBytes(binaryObject);
WriteLine("Binary object has bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
    Console.Write($"{binaryObject[index]:X2} ");
}
WriteLine();
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary object as Base64:\n{encoded}");

#endregion Exploring converting binary string to an object

#region Exploring Paring strings

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-uk");
int friends = int.Parse("23");
DateTime birthday = DateTime.Parse("4 jul 2009");
WriteLine($"I have {friends} friends to invite to my party.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}");

WriteLine("How many eggs are in there? ");
string? input = ReadLine();
if (int.TryParse(input, out int count))
{
    Console.WriteLine($"There are {count} eggs.");
}
else
{
    Console.WriteLine("I could not parse the input.");
}

#endregion Exploring Paring strings