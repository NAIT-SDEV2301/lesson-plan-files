# Practice — Lesson 07A

## Required Task: Encapsulated Book

### Goal
Refactor `Book` so it cannot have invalid values.

### Requirements
- Use a private backing field for pages:
  - `_pages`
- Use a property with validation:
  - `Pages` must be greater than 0
- The constructor must assign `Pages` using the property (so validation is applied)
- Keep `Title` and `Author` read-only properties

### Starter shape (recommended)
```csharp
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
            // validation here
        }
    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages; // assign through property
    }
}
```
