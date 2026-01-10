// Declare and assign variables of different data types
string name = "Alice";
int age = 25;
double height = 1.68;   // in meters
bool isStudent = true;

// Display variable values using String Concatentation
Console.WriteLine("Display variable values using String Concatentation");
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Height (m): " + height);
Console.WriteLine("Is Student? " + isStudent);
// Display variable values using Composite Formatting
Console.WriteLine("Display variable values using Composite Formatting");
Console.WriteLine("Name: {0}\tAge:{1}\tHeight (m): {2}", name, age, height);
Console.WriteLine("Is Student? {0} ", isStudent);
// Display variable values using String Intepolation
Console.WriteLine("Display variable values using String Intepolation");
Console.WriteLine($"Name: {name}\tAge:{age}\tHeight (m): {height}");
Console.WriteLine($"Is Student? {isStudent}");

// Simple interaction with user
Console.WriteLine();
Console.Write("Enter your favorite number: ");
string input = Console.ReadLine();
int favoriteNumber = int.Parse(input);

//Console.WriteLine("Your favorite number is: " + favoriteNumber);
Console.WriteLine($"Your favorite number is: {favoriteNumber}");
