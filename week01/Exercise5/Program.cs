using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayMessage(); 
       string requestedName = PromptUserName();
       Console.WriteLine($"The name is:{requestedName}");
       int favoriteNumber = PromptUserNumber();
       Console.WriteLine($"Your favorite number is: {favoriteNumber}");
       Console.Write("Enter a number to be squared  ");
       int number = int.Parse(Console.ReadLine());
       int userSquaredNumber = SquareNumber(number);
       Console.WriteLine($"The square of {number} is {userSquaredNumber}");
       Console.Write("What is your name?  ");
       string enteredName = Console.ReadLine();
       Console.Write("What is your favorite squared number? ");
       int enteredSquared = int.Parse(Console.ReadLine());
       DisplayResult(enteredName, enteredSquared);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name?  ");
       string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?  ");
        int userFavoriteNumber = int.Parse(Console.ReadLine());
        return userFavoriteNumber;
    } 
    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    } 
    static void DisplayResult(string name, int squareOfNumber)
    {
        Console.Write($"Your name is {name} and your favorite squared is {squareOfNumber}");
    }        
    
}