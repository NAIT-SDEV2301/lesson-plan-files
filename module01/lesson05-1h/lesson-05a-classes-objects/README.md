# Lesson 05A — Classes & Object Instantiation

## Learning Objectives
By the end of this lesson, you will be able to:
- Define a class in C#
- Create objects using `new`
- Access fields and call methods using dot notation (`.`)
- Explain the difference between a class and an object

## Key Concepts
- **Class** = blueprint
- **Object** = instance created from a class
- **Field** = stores state (data)
- **Method** = behavior (actions)

## Example: Student Class
```csharp
public class Student
{
    public string Name;
    public int Age;

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} is {Age} years old.");
    }
}
````

### Creating and using an object

```csharp
Student currentStudent = new Student();
currentStudent.Name = "Alex";
currentStudent.Age = 21;
currentStudent.PrintInfo();
```

## What to do next

Open `PRACTICE.md` and complete the Book activity.
If you get stuck, open the code in `examples/`.

