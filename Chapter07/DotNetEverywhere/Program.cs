WriteLine("I can run everywhere");
WriteLine($"OS version is {Environment.OSVersion}");
if (OperatingSystem.IsMacOS())
{
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10, build: 22000))
{
    Console.WriteLine("I am Windows 11");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
    Console.WriteLine("I am Windows 10");
}
else
{
    Console.WriteLine("I am some other mysterious OS");
}

//WriteLine("Press any key to stop me...");
////ReadKey(intercept: true);

//string name = null;
//int number = 1;
////ArgumentOutOfRangeException.ThrowIfLessThan(number, 5);
//ArgumentException.ThrowIfNullOrWhiteSpace(name);