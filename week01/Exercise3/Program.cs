using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 9;
        Console.Write("What is the magic number?  ");
        string userGuess = Console.ReadLine();
        int guessNumber = int.Parse(userGuess);
        if (guessNumber == magicNumber)
        {
            Console.Write($"Congratulations! you guessed the magic number {magicNumber}");

        }
        else if (guessNumber < magicNumber)
        {
            Console.Write("Make a higher guess.");
        }
        else
        {
            Console.Write("Make a lower guess");
        }
    }
}