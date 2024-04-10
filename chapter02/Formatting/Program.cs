using System.Xml.Linq;
using static System.Console;

int numberOfApples = 34;
decimal pricePerApple = 0.45m;
WriteLine(format: "{0} apples cost {1:c}", arg0: numberOfApples, arg1: pricePerApple * numberOfApples);

string formatted = string.Format(format: "{0} apples cost {1:c}", arg0: numberOfApples, arg1: pricePerApple * numberOfApples);
WriteLine(formatted);

WriteLine("{0} {1} lived in {2}", arg0: "Mark", arg1: "Ken", arg2: "Stockholm");
WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.", "Mark", "Ken", "Stockholm", "Technology", "GDB Group");

WriteLine($"{numberOfApples} apples cost {numberOfApples
* pricePerApple:c}");

string apples = "apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine();
WriteLine(format: "{0,-5} {1,10}", arg0: "Name", arg1: "Count");
WriteLine(format: "{0,-5} {1,10:N0}", arg0: apples, arg1: applesCount);
WriteLine(format: "{0,-5} {1,10:N0}", arg0: bananasText, arg1: bananasCount);

// Write("Please enter your name and press ENTER: ");
// string? firstName = ReadLine();
// Write("Pleace enter your age and press ENTER: ");
// string age = ReadLine()!;
// WriteLine($"You name is {firstName} and your age is {age}");

Write("Press any key combination...");
ConsoleKeyInfo key  = ReadKey();
WriteLine("Key:{0}, Char: {1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);
