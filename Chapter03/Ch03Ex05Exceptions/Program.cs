using static System.Console;

WriteLine("Enter a number between 0 and 255:");
string a = ReadLine();
WriteLine("Enter another number between 0 and 255:");
string b = ReadLine();

try
{
    byte x = byte.Parse(a);
    byte y = byte.Parse(b);
    Console.WriteLine($"{x} divided by {y} is {x / y}");
}
catch (FormatException)
{
    Console.WriteLine("FormatException: Input string was not in the correct format.");
}