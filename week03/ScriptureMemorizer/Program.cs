using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("John", 3, 16);
        string scripturalText = "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(scriptureReference, scripturalText );

        string userInput = "";
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nCongratulations! All words are hidden.");
        }
        else
        {
            Console.WriteLine("\nExiting program");
        }
    }
}