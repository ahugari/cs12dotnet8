namespace AboutMyEnvironment;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(Environment.CurrentDirectory);
        System.Console.WriteLine(Environment.OSVersion.VersionString);
        string name = typeof(Program).Namespace ?? "None!";
        Console.WriteLine($"Namespace: {name}");
    }
}
