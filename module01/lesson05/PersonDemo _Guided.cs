namespace Lesson05.ConsoleApp.Guided
{
	// PersonDemo_Guided.cs (properties + encapsulation)
	// TODOs for students to complete during class.

	using System;

	public class Person
	{
		// TODO: Add a private backing field for age: private int _age;

		// TODO: Add a public read-only property Name (string) set via constructor.

		// TODO: Add a public property Age (int) with:
		//   - get => _age
		//   - private set with validation 1..120 (throw ArgumentOutOfRangeException if invalid)

		// TODO: Implement the constructor Person(string name, int age)
		//   - validate name is not null/whitespace (throw ArgumentException if invalid)
		//   - set Name (trimmed) and Age (use the property to trigger validation)

		// TODO: Implement an instance method Introduce() that writes:
		//   "Hi, my name is {Name} and I am {Age} years old."

		// TODO: Implement a static method DisplayTypeInfo() that prints a brief description
	}

	public class PersonDemo_Guided
	{
		public static void Main()
		{
			Console.WriteLine("=== Person Demo (Guided: Encapsulation + Properties) ===");

			// TODO: Call Person.DisplayTypeInfo()

			// TODO: Create two Person objects with valid names/ages.

			// TODO: Call Introduce() on both objects.

			// BONUS: Try to assign an invalid age (e.g., 0 or 200) in the constructor
			// and observe the exception message. Also note you cannot set Age directly
			// because the setter is private.
		}
	}


}
