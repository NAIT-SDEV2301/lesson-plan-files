namespace Lesson05.ConsoleApp
{
	// PersonDemo.cs (revised best-practice version)
	// Encapsulation with private state + public properties.

	using System;

	public class Person
	{
		private int _age;

		public string Name { get; }

		public int Age
		{
			get => _age;
			private set
			{
				if (value < 1 || value > 120)
					throw new ArgumentOutOfRangeException(nameof(value), "Age must be between 1 and 120.");
				_age = value;
			}
		}

		public Person(string name, int age)
		{
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentException("Name cannot be empty.", nameof(name));

			Name = name.Trim();
			Age = age; // uses the property (and thus validation)
		}

		public void Introduce() =>
			Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");

		public static void DisplayTypeInfo() =>
			Console.WriteLine("Person is a class; each object has encapsulated state exposed via properties.");
	}

	public class PersonDemo
	{
		public static void Main()
		{
			Console.WriteLine("=== Person Demo (Encapsulation + Properties) ===");
			Person.DisplayTypeInfo();

			var alice = new Person("Alice", 25);
			var bob = new Person("Bob", 30);

			alice.Introduce();
			bob.Introduce();

			// Static typing example (won't compile if uncommented):
			// bob.Age = "Thirty"; // ❌ Age is int and has a private setter.
		}
	}

}
