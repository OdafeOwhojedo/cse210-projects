using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessedNumber = 0;
        while (guessedNumber != magicNumber)
        {
            Console.Write("What is the magic number?  ");
            guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber < magicNumber)
            {
                Console.Write("Please make a higher guess. ");
            }
            else if (guessedNumber > magicNumber)
            {
                Console.Write("Please make a lower guess. ");
            }
            else
            {
            Console.WriteLine($"Congratulations! you guessed the magic number {magicNumber}");
            }
        }
        
    }
}