# Lesson 07A — Properties, Fields & Encapsulation

## Learning Objectives
By the end of this lesson, you will be able to:
- Differentiate between fields and properties
- Explain why fields are usually `private`
- Implement automatic and custom properties
- Add validation in property setters to prevent invalid data

## Key Concepts
- A **field** stores data (often `private`)
- A **property** controls access to data
- **Encapsulation** prevents objects from entering an invalid state

## Example: Property With Validation
```csharp
private int _age;

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
```

## What to do next

Open `PRACTICE.md` and refactor `Book` to enforce valid state using properties.
If you get stuck, open the code in `examples/`.


## Optional (Early Finisher): Choose One

### Option A — Car

* Private backing field `_speed`
* Property `Speed` must be between 0 and 200

### Option B — TemperatureSensor

* Private backing field `_temperature`
* Property `Temperature` must be between -50 and 50

## Success Checklist

* [ ] My fields are private.
* [ ] My property setter blocks invalid values.
* [ ] My constructor assigns through properties when validation matters.
