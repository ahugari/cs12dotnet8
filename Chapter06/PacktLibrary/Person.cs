namespace Packt.Shared;

public class Person : IComparable<Person?>
{
    #region Properties

    public string? Name { get; set; }
    public DateTimeOffset Born { get; set; }
    public List<Person> Children = new();

    public List<Person> Spouses = new();
    public bool Married => Spouses.Count > 0;

    #endregion Properties

    #region Methods

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public void WriteChildrenToConsole()
    {
        string term = Children.Count == 1 ? "child" : "children";

        WriteLine($"{Name} has {Children.Count} {term}.");
    }

    public static void Marry(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);
        if (p1.Spouses.Contains(p2) || p2.Spouses.Contains(p1))
        {
            throw new ArgumentException(string.Format("{0} is already married to {1}.", arg0: p1.Name, arg1: p2.Name));
        }
        p1.Spouses.Add(p2);
        p2.Spouses.Add(p1);
    }

    public void Marry(Person partner)
    {
        Marry(this, partner);
    }

    public void OutputSpouses()
    {
        if (Married)
        {
            string term = Spouses.Count == 1 ? "person" : "people";
            Console.WriteLine($"{Name} is married to {Spouses.Count} {term}");
            foreach (Person spouse in Spouses)
            {
                Console.WriteLine($"{spouse.Name}.");
            }
        }
        else
        {
            Console.WriteLine($"{Name} is a singleton.");
        }
    }

    /// <summary>
    /// Static method to "multiply" or procreate and have a child together.
    /// </summary>
    /// <param name="p1">Parent 1</param>
    /// <param name="p2">Parent 2</param>
    /// <returns>A person object that is a child of Parent 1 and Parent 2.</returns>
    /// <exception cref="ArgumentException">Thrown if parents aren't married to each other.</exception>
    public static Person Procreate(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);
        if (!p1.Spouses.Contains(p2) || p2.Spouses.Contains(p2))
        {
            throw new ArgumentException($"{p1.Name} must be married to {p2.Name} in order to procreate with them");
        }

        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}",
            Born = DateTimeOffset.Now
        };

        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }

    //Instance method to multiply
    public Person ProcreateWith(Person person)
    {
        return Procreate(this, person);
    }

    #endregion Methods

    #region Operators

    // define the + operator to "Marry".
    public static bool operator +(Person p1, Person p2)
    {
        Marry(p1, p2);
        return p1.Married && p2.Married;
    }

    public static Person operator *(Person p1, Person p2)
    {
        return Procreate(p1, p2);
    }

    #endregion Operators

    #region Events

    public event EventHandler? Shout;

    public int AngerLevel;

    public void Poke()
    {
        AngerLevel++;

        if (AngerLevel < 3) return;

        if (Shout is not null)
        {
            Shout(this, EventArgs.Empty);
        }
    }

    #endregion Events

    public int CompareTo(Person? other)
    {
        int position;

        if (other is not null)
        {
            if ((Name is not null) && (other.Name is not null))
            {
                position = Name.CompareTo(other.Name);
            }
            else if ((Name is not null) && (other.Name is null))
            {
                position = -1;
            }
            else if ((Name is null) && (other.Name is not null))
            {
                position = 1;
            }
            else
            {
                position = 0;
            }
        }
        else if (other is null)
        {
            position = -1;
        }
        else
        {
            position = 0;
        }

        return position;
    }

    #region OveridingMethods

    public override string ToString()
    {
        return $"{Name} is a {base.ToString()}";
    }

    #endregion OveridingMethods

    public void TimeTravel(DateTime when)
    {
        if (when <= Born)
        {
            throw new PersonException("If you travel back in time to a date earlier than your own birth, the universe will explode!");
        }
        else
        {
            Console.WriteLine($"Welcome to {when:yyyy}!");
        }
    }
}