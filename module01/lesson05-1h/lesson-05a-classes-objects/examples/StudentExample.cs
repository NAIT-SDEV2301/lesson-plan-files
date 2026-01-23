using System;

public class Student
{
    public string Name;
    public int Age;

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} is {Age} years old.");
    }
}
