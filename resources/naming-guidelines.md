# Naming Guidelines (Student Reference)

Good naming makes your code easier to read, debug, and mark.

## General rules
- Use **descriptive variable names**:
  - ✅ `currentStudent`, `firstBook`, `selectedBook`, `accountBalance`
  - ❌ `s`, `b1`, `x`, `temp` (unless the meaning is obvious)
- Use **PascalCase** for class names:
  - `Student`, `Book`, `BankAccount`
- Use **camelCase** for local variables and method names:
  - `currentStudent`, `printSummary()`
- Use **_camelCase** for private fields (backing fields):
  - `_age`, `_pages`, `_balance`

## Loop variables
- Short loop variables are OK for tiny loops:
  - `for (int index = 0; index < 10; index++)`
- Prefer descriptive names for meaningful loops:
  - `for (int studentIndex = 0; studentIndex < students.Count; studentIndex++)`

## "Read it like English"
If your code reads like a sentence, you’re doing it right:
- `currentBook.PrintSummary();`
- `currentStudent.Age = 21;`
```