namespace Packt.Shared;

//mutable record
public record class C1
{
    public string? Name { get; set; }
}

//immutable record
public record class C2(string? Name);

//mutable record struct
public record struct S1
{
    public string? Name { get; set; }
}

//mutable record struct
public record struct S2(string? Name);

//imutable record struct
public readonly record struct S3(string? Name);