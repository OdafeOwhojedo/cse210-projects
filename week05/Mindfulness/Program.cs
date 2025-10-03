using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("-----------------Welcome to the Mindfulness App------------------------");
            Console.WriteLine("\n Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Choose an activity you wish to perform from the list above");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("", "", 80);
                    breathingActivity.Run();
                break;
                case "2":
                   ListingActivity listingActivity = new ListingActivity("", "", 60);
                   listingActivity.Run();
                break;
                case "3":
                   ReflectingActivity reflectingActivity = new ReflectingActivity("", "", 60);
                   reflectingActivity.Run();
                break;
                case "4":
                    running = false;
                break;
                default:
                    Console.WriteLine("Invalid choice. Press ENTER to try again. ");
                    Console.ReadLine();
                break;
            }
        }
        Console.WriteLine("Goodbye! stay focus, stay positive and remain mindful");
        

    }
}