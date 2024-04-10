using System.Xml;

object height = 1.88;
object name = "Mark";

Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length();
int length2 = ((string)name).Length;

Console.WriteLine($"{name} has {length2} characters");

dynamic something;
something = new[] { 1, 2, 3, 4, 5, 6 };
//something = 12;
//something = "Mark";
Console.WriteLine($"The length of {nameof(something)} is {something.Length}");
Console.WriteLine($"something is a {something.GetType()}");

var population = 67_000_000; // 67 million in UK
var weight = 1.88; // in kilograms
var price = 4.99m; //pounds sterling
var fruit = "Watermelon"; //string values using double qoutes
var letter = 'M'; // char values using single quotes
var happy = true; // booleans can only be true or false

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something1.txt");

Person kim = new();
kim.BirthDate = new(1990, 12, 12);

Console.WriteLine(default(int));
Console.WriteLine(default(string)); // this will output as an empty string since its null
Console.WriteLine(default(DateTime));

int number = 12;

Console.WriteLine($"number set to: {number}");
number = default;
Console.WriteLine($"number set to: {number}");

internal class Person
{
    public DateTime BirthDate;
}