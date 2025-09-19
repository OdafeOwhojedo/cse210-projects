using System;
public class BankAccount
{
    private decimal _balance; // Private field to encapsulate the balance

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentException("Initial balance cannot be negative.");
        }
        _balance = initialBalance;
    }

    // Public property to control access to the balance
    public decimal Balance
    {
        get { return _balance; }
        // No public setter to prevent direct external modification
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }
        _balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {_balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }
        if (_balance < amount)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        _balance -= amount;
        Console.WriteLine($"Withdrew {amount:C}. New balance: {_balance:C}");
    }
}