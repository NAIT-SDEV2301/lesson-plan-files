# Common Errors (Student Reference)

## 1) Forgot `new`
❌
```csharp
Student currentStudent = Student();
```

✅

```csharp
Student currentStudent = new Student();
```

## 2) Calling a method on the class instead of an object

❌

```csharp
Student.PrintInfo();
```

✅

```csharp
Student currentStudent = new Student();
currentStudent.PrintInfo();
```

## 3) Default constructor doesn’t exist (after you create a parameterized constructor)

If your class has:

```csharp
public Student(string name, int age) { ... }
```

Then this will fail:

```csharp
Student anotherStudent = new Student();
```

## 4) Property validation missing

If your property setter does this:

```csharp
set => _age = value;
```

then invalid values can still get through.

