using Packt.Shared;

Person harry = new()
{
    Name = "Harry",
    Born = new(year: 2021, month: 12, day: 12, hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};

harry.WriteToConsole();

Person lamech = new() { Name = "Lamech" };
Person adah = new Person() { Name = "Adah" };
Person zillah = new Person() { Name = "Zillah" };

//call the instance method
lamech.Marry(adah);
//call the static method
//Person.Marry(lamech, zillah);
if (lamech + zillah)
{
    Console.WriteLine($"{lamech.Name} and {zillah.Name} successfully got married.");
}
lamech.OutputSpouses();
adah.OutputSpouses();
zillah.OutputSpouses();

Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";

WriteLine($"{baby1.Name} was born on {baby1.Born}.");

Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";

Person baby3 = lamech * adah;
baby3.Name = "Jubal";
Person baby4 = zillah * lamech;
baby4.Name = "Naamah";

adah.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();

for (int i = 0; i < lamech.Children.Count; i++)
{
    Console.WriteLine("{0}'s child #{1} is named \"{2}\".", arg0: lamech.Name, arg1: i + 1, arg2: lamech.Children[i].Name);
}

System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Aplha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");
int key = 2;
WriteLine("Key {0} has value: {1}.", arg0: key, arg1: lookupObject[key]);
WriteLine("Key {0} has value: {1}.", arg0: harry, arg1: lookupObject[harry]);

Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");

harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout_2;
harry.Poke(); harry.Poke(); harry.Poke(); harry.Poke();

Person?[] people =
{
null,
new Person(){Name= "Simon"},
new (){Name = "Jenny"},
new Person(){Name = "Adam"},
new Person(){Name = null},
new Person(){Name = "Richard"}
};

OutputPeopleNames(people, "Initial list of people:");
//Array.Sort(people);
Array.Sort(people, new PersonComparer());
OutputPeopleNames(people, "After sorting using Person's IComparable implementation.");

int a = 3;
int b = 3;

WriteLine($"a:{a}, b: {b}");
WriteLine($"a == b: {a == b}");

Person p1 = new() { Name = "Kevin" };
Person p2 = new Person() { Name = "Kevin" };

WriteLine($"P1:{p1}, P2:{p2}");
WriteLine($"p1.name: {p1.Name}, p2.name: {p2.Name}");
WriteLine($"p1 == p2: {p1 == p2}");

Person p3 = p1;
WriteLine($"p3.name: {p3.Name}");
WriteLine($"p1==p3: {p1 == p3}");

//string is the only reference type that's implemented to behave like a value type when compared
WriteLine($"p1.name: {p1.Name}, p2.name: {p2.Name}");
WriteLine($"p1.name == p2.name: {p1.Name == p2.Name}");

DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;
WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = {dv3.X}, {dv3.Y}");

DisplacementVector dv4 = new();
WriteLine($"({dv4.X}, {dv4.Y})");

DisplacementVector dv5 = new DisplacementVector(3, 5);
WriteLine($"dv1.Equals(dv5): {dv1.Equals(dv5)}");
WriteLine($"dv1==dv5: {dv1 == dv5}");

Employee john = new Employee()
{
    Name = "John Jones",
    Born = new DateTimeOffset(year: 1990, month: 02, day: 02, 0, 0, 0, TimeSpan.Zero)
};
john.WriteToConsole();

john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 03, day: 01);
WriteLine($"{john.Name} was hired on {john.HireDate:yyyy-MM-dd}");

WriteLine(john.ToString());
Employee aliceInEmployee = new()
{
    Name = "Alice",
    EmployeeCode = "AA123"
};
Person aliceInPerson = aliceInEmployee;
aliceInEmployee.WriteToConsole();
aliceInPerson.WriteToConsole();
WriteLine(aliceInPerson.ToString());
WriteLine(aliceInEmployee.ToString());

if (aliceInPerson is Employee explicitAlice)
{
    Console.WriteLine($"{nameof(aliceInPerson)} is an employee");
}

Employee? aliceAsEmployee = aliceInPerson as Employee;
if (aliceAsEmployee is not null)
{
    Console.WriteLine($"{nameof(aliceInPerson)} as an employee");
}

try
{
    john.TimeTravel(when: new DateTime(2000, 10, 10));
    john.TimeTravel(when: new DateTime(1890, 10, 10));
}
catch (PersonException ex)
{
    WriteLine(ex.Message);
}

string email1 = "pamel@test.com";
string email2 = "ian@test.com";
string email3 = "a@b";
WriteLine($"{email1} is a valid e-mail address: {email1.IsValidEmail()}");
WriteLine($"{email2} is a valid e-mail address: {email2.IsValidEmail()}");
WriteLine($"{email3} is a valid e-mail address: {email3.IsValidEmail()}");

C1 c1 = new() { Name = "Bob" };
C2 c2 = new(Name: "Bob");
//c2.Name = "Bill";
S1 s1 = new S1() { Name = "Bob" };
s1.Name = "Bill";
S2 s2 = new S2() { Name = "Bob" };
s2.Name = "Bill";
S3 s3 = new S3();
//s3.Name = "Bill";