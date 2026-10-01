# Dependency Injection Exercises

These exercises require you to register services and inject them into Razor components. For each exercise, create a new Razor page and update the NavMenu so that it can be navigated to through the UI.

Before starting, add the service class to your project and register it in `Program.cs` using the appropriate method:

`builder.Services.AddSingleton<ServiceName>();`

## ColorService

1. Create the `ColorService` class that includes the following code:
```
private static readonly string[] Colors =
{
    "#FF6B6B", "#6BCB77", "#4D96FF", "#FFD93D",
    "#C77DFF", "#FF922B", "#20C997", "#F06595"
};

public string GetRandomColor()
{
    var random = new Random();
    return Colors[random.Next(Colors.Length)];
}
```
2. Register `ColorService` in `Program.cs` as a Singleton.
3. Create a new page and inject the `ColorService` using the `@inject` directive.
4. Add a `<div>` to the page with some text inside it, for example: "This is a colored box."
5. Add a button to the page labelled "Change Color".
6. In the `@code` block, declare a `string` variable called `currentColor` and initialize it to `"#FFFFFF"`.
7. Bind the `background-color` style of the `<div>` to the `currentColor` variable using an inline style:
    - `style="background-color: @currentColor"`
8. When the button is clicked, call `GetRandomColor()` on the `ColorService` and assign the result to `currentColor`.
9. The background color of the `<div>` should change to a new random color each time the button is clicked.

## TipCalculatorService

1. Create the `TipCalculatorService` that includes the following code:
```
public decimal CalculateTip(decimal billAmount, int tipPercentage)
{
    return Math.Round(billAmount * (tipPercentage / 100m), 2);
}

public decimal CalculateTotal(decimal billAmount, int tipPercentage)
{
    return billAmount + CalculateTip(billAmount, tipPercentage);
}

public decimal SplitTotal(decimal billAmount, int tipPercentage, int numberOfPeople)
{
    return Math.Round(CalculateTotal(billAmount, tipPercentage) / numberOfPeople, 2);
}
```
2. Register `TipCalculatorService` in `Program.cs` as a Transient service.
3. Create a new page and inject the `TipCalculatorService` using the `@inject` directive.
4. Add the following input fields to the page:
    - Bill Amount
        - A number input bound to a `decimal` variable called `billAmount`
    - Tip Percentage
        - A number input bound to an `int` variable called `tipPercentage`
    - Number of People
        - A number input bound to an `int` variable called `numberOfPeople`
5. Add a button labelled "Calculate".
6. In the `@code` block, add the above variables and declare the following `decimal` variables, each initialized to `0`:
    - `tipAmount`
    - `total`
    - `perPerson`
7. When the button is clicked, call the appropriate methods on the `TipCalculatorService` and assign the results to the variables above.
8. Display the following results on the page beneath the button:

Tip Amount: {tipAmount} Total: {total}  
Per Person: ${perPerson}
