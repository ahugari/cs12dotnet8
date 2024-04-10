var animals = new Animal?[]
{
    new Cat
    {
        Name = "Karen",
        Born = new (2022, 8, 23),
        Legs = 4,
        IsDomestic = true
    },
    null,
    new Cat
    {
        Name = "Mufasa",
        Born = new (1994, 6, 12)
    },
    new Spider
    {
        Name = "Sid Viscious",
        Born = DateTime.Today,
        IsPoisonous = true,
    },
    new Spider
    {
        Name = "Captain Furry",
        Born = DateTime.Today
    }
};

foreach (Animal? animal in animals)
{
    string message;
    switch (animal)
    {
        case Cat { Legs: 4 } fourLeggedCat:
            message = $"The cat named {fourLeggedCat.Name} has four legs.";
            break;

        case Cat wildCat when !wildCat.IsDomestic:
            message = $"The non-domestic cat is named {wildCat.Name}";
            break;

        case Cat cat: message = $"The cat is named {cat.Name}"; break;

        case Spider { IsPoisonous: true } poisonousSpider:
            message = $"The {poisonousSpider.Name} spider is poisonous.Run!";
            break;

        case Spider spider: message = $"{spider.Name} is a spider."; break;

        case null: message = "The animal is null"; break;

        default:
            message = $"{animal?.Name} is a {animal?.GetType().Name}";
            break;
    }

    message = animal switch
    {
        Cat { Legs: 4 } fourLeggedCat => $"The cat named {fourLeggedCat.Name} has four legs.",
        Cat wildCat when !wildCat.IsDomestic => $"The non-domestic cat is named {wildCat.Name}",
        Cat cat => $"The cat is named {cat.Name}",
        Spider spider when spider.IsPoisonous => $"The {spider.Name} spider is poisonous. Run!",
        null => "The animal is null",
        _ => $"{animal.Name} is a {animal.GetType().Name}."
    };

    Console.WriteLine($"Switch statement: {message}");
}