namespace Packt.Shared;

public partial class Person
{
    public const string Species = "Homo Sapiens";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;

    #region Data or state for this person

    public string? Name;
    public DateTimeOffset Born;

    //This has been moved to PersonAutoGen.cs as a property.
    //public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;

    public List<Person> Children => new();

    #endregion Data or state for this person

    #region Constructors: Called when using new to instantiate a type

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    #endregion Constructors: Called when using new to instantiate a type

    #region Methods: Actions the type can perform

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'.";
    }

    public string SayHello(string name)
    {
        return $"{Name} says, 'Hello {name}!'";
    }

    public string OptionalParameters(int count, string command = "Run!", double number = 0.0, bool active = true)
    {
        return string.Format(format: "command is {0}, number is {1}, active is {2}", arg0: command, arg1: number, arg2: active);
    }

    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        z = 100;
        int a = w++;
        //x++;
        int b = y++;
        int c = z++;
        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
        WriteLine($"In the method: 1={a}, x={x}, 2={b}, 3={c}");
    }

    #endregion Methods: Actions the type can perform

    #region Exploring Tuples

    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apple", Number: 5);
    }

    public (string, int) GetFruit()
    {
        return ("Apple", 5);
    }

    #endregion Exploring Tuples

    #region Object Deconstruction

    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FavoriteAncientWonder;
    }

    #endregion Object Deconstruction

    #region Local functions

    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
        }
        return localFactorial(number);
        int localFactorial(int localNumber)
        {
            if (localNumber == 0) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }

    #endregion Local functions
}