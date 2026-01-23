using System;

public class Student
{
    private int _age;

    public string Name { get; }

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentException("Age must be between 0 and 120.");
            }

            _age = value;
        }
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
