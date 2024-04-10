WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args)
{
    Console.WriteLine(arg);
}

if (args.Length < 3)
{
    Console.WriteLine("You must specify two colors and cursor size, e.g");
    Console.WriteLine("dotnet run red yellow 50");
    return;
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0], ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1], ignoreCase: true
    );

try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    Console.WriteLine("the current platform does not support changing the size of the cursor");
}