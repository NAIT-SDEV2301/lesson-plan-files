# Practice — Lesson 05B

## Required Task: Refactor Book to Use a Constructor

### Requirements
Refactor your `Book` class so that:
- `Title`, `Author`, and `Pages` are set **in the constructor**
- The properties should not be changeable from outside the class (use read-only properties)
- `PrintSummary()` still prints a one-line summary

### Starter shape (recommended)
```csharp
public class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Pages { get; }

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
````

In `Main`:

* Create two books like:

```csharp
Book firstBook = new Book("Clean Code", "Robert C. Martin", 464);
```

## Optional (Early Finisher): BankAccount

Create a `BankAccount` class with:

* `AccountNumber` (string)
* `AccountHolder` (string)
* `Balance` (decimal)
* Constructor requiring all values
* Method `PrintAccountSummary()`

## Success Checklist

* [ ] I can explain why a constructor is useful.
* [ ] I used descriptive variable names like `firstBook`, `secondBook`.
* [ ] My objects cannot exist without required data.
