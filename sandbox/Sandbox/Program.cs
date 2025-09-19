using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        BankAccount myAccount = new BankAccount(1000m);

        // Accessing balance through the public Balance property
        Console.WriteLine($"Current balance: {myAccount.Balance:C}");

        myAccount.Deposit(200m);
        myAccount.Withdraw(50m);

        // Attempting to directly modify the private _balance field would result in a compile-time error
        // myAccount._balance = 5000m; // This line would not compile

        Console.WriteLine($"Final balance: {myAccount.Balance:C}");


    }
}