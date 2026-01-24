# Exercise Unit Testing
# Point of Sale System

A point of sale system class has been created, we need to write some tests in a new test project for it.

Use [Theory] and [Fact] where appropriate whe writing the tests. Follow the Unit Testing Style Guide in Brightspace.

*Note:* The Coupon object accepts a value from 0.0 to 1.0, representing the discount. For example, a value of 0.1 would mean a 10% discount. So an item worth $100 would cost $90.

## Requirements

1. Create a new xUnit test project in the solution called "PointOfSaleTests".
2. Change the UnitTest1.cs file name and class to be "PointOfSaleUnitTests"
3. Write the following tests for the `PointOfSale` methods:
    - `ProcessTransaction()`:
        - A test that validates a transaction that will return change (customerAmount is greater than finalPrice)
        - A test that validates a transaction that will return no change (customerAmount is equal to finalPrice)
        - A test that validates that an ArgumentOutOfRangeException is thrown when the customer does not provide enough money (customerAmount is less than finalPrice)
    - `ApplyDiscount()`:
        - A test that validates the correct discount is applied for "None", "Bronze", "Silver", and "Gold" loyalties.
        - A test that validates that an ArgumentNullException is thrown when the user sends "null", an empty string, or a string with only whitespace for the loyalty.
    - `ApplyCoupon()`:
        - A test that validates a valid coupon is applied to the itemPrice
        - A test that validates that an invalid coupon throws the 