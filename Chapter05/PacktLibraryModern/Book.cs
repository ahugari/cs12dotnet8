using System.Diagnostics.CodeAnalysis;

namespace Packt.Shared;

public class Book
{
    public string? Isbn;
    public string? Title;
    public string? Author;
    public int PageCount;

    public Book()
    {
    }

    [SetsRequiredMembers]
    public Book(string? isbn, string? title)
    {
        Isbn = isbn;
        Title = title;
    }
}