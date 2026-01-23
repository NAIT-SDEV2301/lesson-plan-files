using System;

public class Book
{
    private int _pages;

    public string Title { get; }
    public string Author { get; }

    public int Pages
    {
        get => _pages;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Pages must be greater than zero.");
            }

            _pages = value;
        }
    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public void PrintSummary()
    {
        Console.WriteLine($"{Title} by {Author}, {Pages} pages");
    }
}
