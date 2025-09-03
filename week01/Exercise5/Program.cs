using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome(); 
       string requestedName = PromptUserName();
       int favoriteNumber = PromptUserNumber();
       int userSquaredNumber = SquareNumber(favoriteNumber);
       DisplayResult(requestedName, userSquaredNumber);
    }
    static void DisplayWelcome()
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
        Console.Write($" {name}, the square of your favorite number is {squareOfNumber}");
    }        
    
}