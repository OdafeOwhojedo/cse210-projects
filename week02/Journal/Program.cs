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
                  string userResponse = Console.ReadLine();
                  Entry newEntry = new Entry(dateText, nextPrompt, userResponse);
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
                  Console.WriteLine("Enter the name of the file you want to load your journal enteries from");
                  nameOfFile = Console.ReadLine();
                  journal.LoadFromFile(nameOfFile);
                   break;
                case "5":
                    Console.WriteLine("Eciting Journal. Goodbye!");
                    return;
                default:
                   Console.WriteLine("Invalid option, please try again");
                    break;
            }

        }
        
        


    }
}