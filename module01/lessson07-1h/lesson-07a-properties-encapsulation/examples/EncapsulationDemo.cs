using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07.ConsoleApp
{
	// EncapsulationDemo.cs
	// Demonstrates why we use encapsulation in C# classes.

	using System;

	// ❌ BAD PRACTICE: Public fields (no encapsulation)
	public class BankAccountPublic
	{
		public string AccountNumber;
		public decimal Balance;
	}

	// ✅ BEST PRACTICE: Encapsulation with private fields + public properties
	public class BankAccount
	{
		private decimal _balance;

		public string AccountNumber { get; }

		public decimal Balance
		{
			get => _balance;
			private set
			{
				if (value < 0)
					throw new ArgumentOutOfRangeException(nameof(value), "Balance cannot be negative.");
				_balance = value;
			}
		}

		public BankAccount(string accountNumber, decimal initialBalance)
		{
			if (string.IsNullOrWhiteSpace(accountNumber))
				throw new ArgumentException("Account number is required.", nameof(accountNumber));

			AccountNumber = accountNumber;
			Balance = initialBalance; // goes through property → validation
		}

		public void Deposit(decimal amount)
		{
			if (amount <= 0)
				throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive.");
			Balance += amount;
		}

		public void Withdraw(decimal amount)
		{
			if (amount <= 0)
				throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive.");
			if (amount > Balance)
				throw new InvalidOperationException("Insufficient funds.");
			Balance -= amount;
		}
	}

	public class EncapsulationDemo
	{
		public static void Main()
		{
			Console.WriteLine("=== Encapsulation Demo ===");

			// ❌ Using public fields: no protection
			var accountPublic = new BankAccountPublic();
			accountPublic.AccountNumber = "12345";
			accountPublic.Balance = -5000; // ❌ Allowed! Invalid state.
			Console.WriteLine($"[Public] Account: {accountPublic.AccountNumber}, Balance: {accountPublic.Balance}");

			Console.WriteLine();

			// ✅ Using properties with encapsulation
			var account = new BankAccount("67890", 1000);
			Console.WriteLine($"[Encapsulated] Account: {account.AccountNumber}, Balance: {account.Balance}");

			account.Deposit(500);
			Console.WriteLine($"After deposit: {account.Balance}");

			account.Withdraw(300);
			Console.WriteLine($"After withdrawal: {account.Balance}");

			// Uncommenting this line would cause a compile-time error:
			// account.Balance = -9999; // ❌ Cannot set Balance directly (private setter).
		}
	}

}
