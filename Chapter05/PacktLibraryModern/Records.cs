namespace Packt.Shared;

public class ImmutablePerson
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}

public record ImmutableVehicle
{
    public int Wheels { get; set; }
    public string? Color { get; set; }
    public string? Brand { get; set; }
}

public record ImmutableAnimal(string Name, string Species);