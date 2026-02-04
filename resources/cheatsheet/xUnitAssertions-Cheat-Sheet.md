# xUnit Assertions – Quick Cheat Card (Lesson 9)

## Basic Test Attributes

```csharp
[Fact]          // A single test case
[Theory]        // Parameterized test
[InlineData()]  // Data for a Theory
```

## Arrange – Act – Assert (AAA)

```csharp
// Arrange
var circle = new Circle(5);

// Act
var area = circle.GetArea();

// Assert
Assert.Equal(78.54, area, precision: 2);
```

## Equality & Comparison

### Exact equality

```csharp
Assert.Equal(expected, actual);
Assert.NotEqual(expected, actual);
```

### Floating-point values (IMPORTANT)

```csharp
// Preferred (precision = decimal places)
Assert.Equal(78.54, area, precision: 2);

// Alternative (range)
Assert.InRange(area, 78.53, 78.55);
```

## Boolean Assertions

```csharp
Assert.True(condition);
Assert.False(condition);
```

Example:

```csharp
Assert.True(account.Balance >= 0);
```

## Null Checks

```csharp
Assert.Null(value);
Assert.NotNull(value);
```

## Collection Assertions

```csharp
Assert.Empty(collection);
Assert.NotEmpty(collection);

Assert.Contains(item, collection);
Assert.DoesNotContain(item, collection);
```

## String Assertions

```csharp
Assert.Contains("expected text", actualString);
Assert.StartsWith("Hello", actualString);
Assert.EndsWith("!", actualString);
```

💡 **Tip**: Prefer `Contains` for exception messages.

## Exception Assertions (Very Important)

### Assert an exception is thrown

```csharp
Assert.Throws<InvalidOperationException>(() =>
    account.Withdraw(200));
```

### Assert exception + message

```csharp
var ex = Assert.Throws<ArgumentException>(() =>
    account.Deposit(-1));

Assert.Contains("Negative deposit", ex.Message);
```

❌ Don’t catch exceptions manually
✅ Always use `Assert.Throws<T>()`

## Parameterized Tests (`[Theory]`)

```csharp
[Theory]
[InlineData(1.0, 3.14)]
[InlineData(5.0, 78.54)]
public void GetArea_WithDifferentRadii_ReturnsCorrectArea(
    double radius, double expected)
{
    var circle = new Circle(radius);

    Assert.Equal(expected, circle.GetArea(), precision: 2);
}
```

## Multiple Assertions (Use Sparingly)

```csharp
Assert.Multiple(
    () => Assert.Equal(32, rect.GetArea()),
    () => Assert.Equal(24, rect.GetPerimeter())
);
```

💡 Prefer **one logical behavior per test** when possible.

## Common Mistakes to Avoid ❌

* Comparing doubles **without** tolerance
* Catching exceptions instead of asserting them
* Multiple unrelated assertions in one test
* Testing only getters/setters
* Writing tests *after* all code is finished

## Mental Checklist Before Submitting

* [ ] Uses Arrange–Act–Assert
* [ ] Tests behavior, not implementation
* [ ] Fails first when written
* [ ] Clear test name
* [ ] No magic numbers unexplained
