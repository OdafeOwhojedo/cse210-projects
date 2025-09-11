using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator newPrompt = new PromptGenerator();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToString();
        string nextPrompt;
        string userResponse;
        string propheticQuote;
        string entryLocation;
        string nameOfFile;
        Console.WriteLine("----------Welcome to your electronic Journal----------");
        while (true)
        {
           Console.WriteLine("\n Menu:");
           Console.WriteLine("1. Add New Entry");
           Console.WriteLine("2. View Entries");
           Console.WriteLine("3. Save Journal");
           Console.WriteLine("4. Load Journal");
           Console.WriteLine("5. Exit");
       
           string userChoice = Console.ReadLine();
           switch (userChoice)
           {
              case "1":
                  
                  nextPrompt = newPrompt.GetRandomPrompt();
                  Console.WriteLine(nextPrompt);
                  Console.Write("Enter your response: ");
                  userResponse = Console.ReadLine();
                  Console.WriteLine("Where was i when I made this entry?");
                  entryLocation = Console.ReadLine();
                  Console.WriteLine("What prophetic quote or invitation from a general authority did I memorized today?");
                  propheticQuote = Console.ReadLine();
                  Entry newEntry = new Entry(dateText, nextPrompt, userResponse,entryLocation, propheticQuote);
                  journal.AddEntry(newEntry);
                  break;
                case "2":
                  journal.DisplayAll();
                  break;
                case "3":
                  Console.WriteLine("Enter the name of the file you want to save your journal to");
                  nameOfFile = Console.ReadLine();
                  journal.SaveToFile(nameOfFile);
                  break;
                case "4":
                  Console.WriteLine("Enter the name of the file you want to load your journal entries from");
                  nameOfFile = Console.ReadLine();
                  journal.LoadFromFile(nameOfFile);
                   break;
                case "5":
                    Console.WriteLine("Exiting your Journal. Stay focused, be determined, Continue writing. Goodbye!");
                    return;
                default:
                   Console.WriteLine("You entered an invalid option, please try again.");
                    break;
            }

        }
        
        


    }
}