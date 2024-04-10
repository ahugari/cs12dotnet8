using Packt.Shared;

internal partial class Program
{
    private static void OutputPeopleNames(IEnumerable<Person?> people, string title)
    {
        WriteLine(title);
        foreach (Person? p in people)
        {
            Console.WriteLine("{0}", p is null ? "<null> person" : p.Name ?? "<null> name");
        }
    }
}