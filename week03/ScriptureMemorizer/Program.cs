using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        string book = "";
        int chapter = 0;
        int startVerse = 0;
        int endVerse = 0;
        string scripturalText = "";
        
        Console.WriteLine("----------Welcome to your Scripture Memorizer Program----------");
        while (true)
        {
           Console.WriteLine("\n Menu:");
           Console.WriteLine("1. Memorize a single-verse scripture");
           Console.WriteLine("2. Memorize a multi-verse scripture");
           Console.WriteLine("3. Exit");
       
           string userChoice = Console.ReadLine();
           switch (userChoice)
           {
              case "1":
                  string scriptureFile = "ScriptureMemorizer(SingleVerse).csv";
                  string [] scriptureWithSingleVerse = File.ReadAllLines(scriptureFile);
                  scriptureWithSingleVerse.Skip(1).ToArray();
                  Random randomScripturePosition = new Random();//Create a new random class object.
                  int scriptureReferencePosition = randomScripturePosition.Next(0, scriptureWithSingleVerse.Length);//Randomly pick an integer value that will indicate the position of a prompt in the prompt list.
                  string scriptureToMemorize = scriptureWithSingleVerse[scriptureReferencePosition];//Pick a prompt by its integer position and assigned it to the string variable.
                  string [] scriptureToMemorizeArray = scriptureToMemorize.Split(',');
                  book = scriptureToMemorizeArray[0];
                  chapter = int.Parse(scriptureToMemorizeArray[1]);
                  startVerse = int.Parse(scriptureToMemorizeArray[2]);
                  scripturalText = scriptureToMemorizeArray[3];
                  
                  Reference scriptureReference = new Reference(book, chapter, startVerse);
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
                           scripture.HideRandomWords(2);
                       }
                  }
                  Console.Clear();
                  Console.WriteLine(scripture.GetDisplayText());
                    if (scripture.IsCompletelyHidden())
                    {
                        Console.WriteLine("\nCongratulations! You did well. All words are hidden.");
                    }
                    else
                    {
                        Console.WriteLine("\nExiting program. Stay focused, be determined, Continue memorizing. Goodbye!");
                        return;
                     
                    }
                   break;
                case "2":
        
                  string multiVerseScriptureFile = "ScriptureMemorizer(MultiVerse).csv";
                  string [] scriptureWithMultiVerse = File.ReadAllLines(multiVerseScriptureFile);
                  scriptureWithMultiVerse.Skip(1).ToArray();
                  Random multiVerseScripturePosition = new Random();//Create a new random class object.
                  int multiVerseScriptureReferencePosition = multiVerseScripturePosition.Next(0, scriptureWithMultiVerse.Length);//Randomly pick an integer value that will indicate the position of a prompt in the prompt list.
                  string multiVerseScriptureToMemorize = scriptureWithMultiVerse[multiVerseScriptureReferencePosition];//Pick a prompt by its integer position and assigned it to the string variable.
                  string [] multiVerseScriptureToMemorizeArray = multiVerseScriptureToMemorize.Split(',');
                  book = multiVerseScriptureToMemorizeArray[0];
                  chapter = int.Parse(multiVerseScriptureToMemorizeArray[1]);
                  startVerse = int.Parse(multiVerseScriptureToMemorizeArray[2]);
                  endVerse = int.Parse(multiVerseScriptureToMemorizeArray[3]);
                  scripturalText = multiVerseScriptureToMemorizeArray[4];
                  
                  Reference multiVerseReference = new Reference(book, chapter, startVerse, endVerse );
                  Scripture multiVerseScripture = new Scripture(multiVerseReference, scripturalText );
                  string multiChoice = "";
                  while (multiChoice.ToLower() != "quit" && !multiVerseScripture.IsCompletelyHidden())
                  {
                      Console.Clear();
                      Console.WriteLine(multiVerseScripture.GetDisplayText());
                      Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit");
                      multiChoice = Console.ReadLine();
                      if (multiChoice.ToLower() != "quit")
                      {
                         multiVerseScripture.HideRandomWords(2);
                      }
                  }
                  Console.Clear();
                  Console.WriteLine(multiVerseScripture.GetDisplayText());
                  if (multiVerseScripture.IsCompletelyHidden())
                  {
                     Console.WriteLine("\nCongratulations! You did well.All words are hidden.");
                  }
                  else
                  {
                     Console.WriteLine("\nExiting program. Stay focused, be determined, Continue memorizing. Goodbye!");
                     return;
                  }

                  break;
                case "3":
                  Console.WriteLine("Exiting program. Stay focused, be determined, Continue memorizing. Goodbye!");
                    return;
                
                default:
                   Console.WriteLine("You entered an invalid option, please try again.");
                    break;
            }

        
        } 
    }
}