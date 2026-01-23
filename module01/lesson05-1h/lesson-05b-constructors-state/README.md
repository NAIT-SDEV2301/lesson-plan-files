# Lesson 05B — Constructors & Object State

## Learning Objectives
By the end of this lesson, you will be able to:
- Explain what a constructor does
- Create a parameterized constructor
- Initialize object state at creation time
- Understand why uninitialized objects can cause bugs

## Key Concepts
- A **constructor** runs automatically when you create an object with `new`.
- Constructors help ensure objects start in a valid, useful state.
- If you create a constructor with parameters, a default constructor may not exist.

## Example: Student With Constructor
```csharp
public class Student
{
    public string Name { get; }
    public int Age { get; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} is {Age} years old.");
    }
}
```

```csharp
Student currentStudent = new Student("Alex", 21);
currentStudent.PrintInfo();
```

## What to do next

Open `PRACTICE.md` and refactor `Book` to use a constructor.
If you get stuck, open the code in `examples/`.

