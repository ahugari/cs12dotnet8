using Packt.Shared;
using Fruit = (string Name, int Number);

ConfigureConsole();

#region Exploring type members

Person bob = new();
bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 18, minute: 28, second: 0,
    offset: TimeSpan.FromHours(+3));
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.LighthouseOfAlexandria;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.ColossusOfRhodes;
WriteLine(bob);
WriteLine(format: "{0} was born on {1:D}.", arg0: bob.Name, arg1: bob.Born);
WriteLine($"{bob.Name}'s favorite wonder is {bob.FavoriteAncientWonder}. Its integer is {(int)bob.FavoriteAncientWonder}");
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");
WriteLine($"{bob.Name} is a {Person.Species}.");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

Person alice = new()
{
    Name = "Alice Jones",
    Born = new DateTimeOffset(1990, 5, 7, 19, 10, 0, TimeSpan.FromHours(+2))
};
WriteLine(format: "{0} was born on {1:d}.", arg0: alice.Name, arg1: alice.Born);

Person alfred = new();
alfred.Name = "Alfred";
bob.Children.Add(alfred);
bob.Children.Add(new Person { Name = "Bella" });
bob.Children.Add(new() { Name = "Zella" });
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
bob.WriteToConsole();
Console.WriteLine(bob.GetOrigin());
foreach (Person child in bob.Children)
{
    Console.WriteLine($"> {child.Name}");
}
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Milly"));
WriteLine(bob.OptionalParameters(12, number: 21.4, command: "Hide!"));

#endregion Exploring type members

#region Exploring static type members

BankAccount.InterestRate = 0.012M;

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mr.Jones";
jonesAccount.Balance = 2400;
WriteLine("{0} earned {1:C} interest.", arg0: jonesAccount.AccountName, arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerriersAccount = new();
gerriersAccount.AccountName = "Ms. Gerriers";
gerriersAccount.Balance = 98;
WriteLine("{0} earned {1:C} interest.", arg0: gerriersAccount.AccountName, arg1: gerriersAccount.Balance * BankAccount.InterestRate);

#endregion Exploring static type members

//Book book = new()
//{
//    Isbn = "978-1803237800",
//    Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
//};

Book book = new(isbn: "978-1803237800", title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J. Price",
    PageCount = 124
};

WriteLine("{0}:{1} written by {2} has {3:N0} pages.", book.Isbn, book.Title, book.Author, book.PageCount);

Person blankPerson = new();
WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.", arg0: blankPerson.Name, arg1: blankPerson.HomePlanet, arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.", arg0: gunny.Name, arg1: gunny.HomePlanet, arg2: gunny.Instantiated);

int a = 10;
int b = 20;
int c = 30;
int d = 40;
WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

int e = 50;
int f = 60;
int g = 70;
WriteLine($"Before: e={e}, f={f}, g={g}");
bob.PassingParameters(e, f, ref g, out int h);
WriteLine($"After: e={e}, f={f}, g={g}, h={h}");

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");
var namedFruit = bob.GetNamedFruit();
WriteLine($"{namedFruit.Name}, {namedFruit.Number} there are.");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

Fruit fruitNamed = bob.GetNamedFruit();
WriteLine($"{fruitNamed.Name}, {fruitNamed.Number} there are.");

(string Name, int Number) = bob.GetFruit();
WriteLine($"Deconstructed Tuple: {Name}, {Number}");

var (name1, dob1) = bob;
WriteLine($"Deconstructed Person: {name1}, {dob1}");
var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed Person: {name2}, {dob2}, {fav2}");

int number = -1;
try
{
    Console.WriteLine($"{number}! is {Person.Factorial(number)}.");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
}

Person sam = new()
{
    Name = "Sam",
    Born = new(1900, 12, 12, 0, 0, 0, TimeSpan.Zero)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
string color = "red";
try
{
    sam.FavoritePrimaryColor = color;
    Console.WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");
}
catch (Exception ex)
{
    Console.WriteLine("Tried to set '{0}' to '{1}': '{2}'", nameof(sam.FavoritePrimaryColor), color, ex.Message);
}

sam.Children.Add(new()
{
    Name = "Charlie",
    Born = new DateTimeOffset(2012, 09, 01, 0, 0, 0, TimeSpan.Zero)
});
sam.Children.Add(new()
{
    Name = "Ella",
    Born = new DateTimeOffset(2011, 03, 11, 0, 0, 0, TimeSpan.Zero)
});
//Get using Children list
WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");
//Get using the int indexer
WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");
//Get using the string indexer
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");

Passenger[] passengers = [
    new FirstClassPassenger{AirMiles = 1_900, Name = "suman"},
    new FirstClassPassenger{AirMiles = 2_323, Name="Lucy"},
    new BusinessClassPasseger{ Name = "Skylar"},
    new CoachClassPassenger{ CarryOnKG = 09, Name="Sumna"},
    new CoachClassPassenger{ CarryOnKG = 0, Name= "Amit"}
    ];
foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        /* C# 8 syntax
        FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
        FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
        FirstClassPassenger _ => 2_000M,*/
        //C# 9 and later syntax
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35_000 => 1_500M,
            > 15_000 => 1_750M,
            _ => 2_000M,
        },
        BusinessClassPasseger _ => 1_000M,
        //relational pattern matching
        CoachClassPassenger { CarryOnKG: < 10.0 } => 500M,
        CoachClassPassenger => 650M,
        _ => 800M
    };
    Console.WriteLine($"Flight costs {flightCost:C} for {passenger}.");
}

ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};

//jeff.FirstName = "Leon";

ImmutableVehicle car = new ImmutableVehicle()
{
    Brand = "Mazda RX-5 RF",
    Color = "Soul Red Crystal Metallic",
    Wheels = 4
};

ImmutableVehicle repaintedCar = car with { Color = "Polymetal Grey Metallic" };
WriteLine($"Original car color was {car.Color}.");
WriteLine($"New car color is {repaintedCar.Color}.");

AnimalClass ac1 = new AnimalClass() { Name = "cat" };
AnimalClass ac2 = new AnimalClass() { Name = "cat" };
WriteLine($"ax1 == ax2: {ac1 == ac2}");
AnimalRecord ar1 = new() { Name = "cat" };
AnimalRecord ar2 = new() { Name = "cat" };
WriteLine($"ar1 == ar2: {ar1 == ar2}");

ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar;
WriteLine($"{who} is a {what}.");

Headset vp = new("Apple", "Vision Pro");
WriteLine($"{vp.ProductName} is made by {vp.Manufacturer}");

Headset holo = new();
WriteLine($"{holo.ProductName} is made by {holo.Manufacturer}.");
Headset mq = new Headset { Manufacturer = "Meta", ProductName = "Quest 3" };
WriteLine($"{mq.ProductName} is made by {mq.Manufacturer}.");