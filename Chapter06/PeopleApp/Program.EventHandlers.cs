using Packt.Shared;

internal partial class Program
{
    private static void Harry_Shout(object? sender, EventArgs e)
    {
        if (sender is null) return;

        if (sender is not Person person) return;

        WriteLine($"{person.Name} is this angry: {person.AngerLevel}");
    }

    private static void Harry_Shout_2(object? sender, EventArgs e)
    {
        WriteLine("Stop it!");
    }
}