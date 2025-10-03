using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        var activities = new List<object> {new BreathingActivity(), new ListingActivity(), new ReflectingActivity()};
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("-----------------Welcome to the Mindfulness App------------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Choose an activity you wish to perform from the list above");
            string userChoice = Console.ReadLine()?.Trim().ToLower();
            switch (userChoice)
            {
                case "1":
                ((BreathingActivity)activities[0]).Run();
                break;
                case "2":
                ((ListingActivity)activities[1]).Run();
                break;
                case "3":
                ((ReflectingActivity)activities[2]).Run();
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
        Console.WriteLine("Goodbye! stay mindful");
        // while (true)
        // {
        //     Console.Clear();
        //     Console.WriteLine("Relaxation Activities Program");
        //     Console.WriteLine("1. Breathing Activity");
        //     Console.WriteLine("2. Reflection Activity");
        //     Console.WriteLine("3. Listing Activity");
        //     Console.WriteLine("4. Exit");
        //     Console.Write("Choose an activity (1-4): ");

            // string choice = Console.ReadLine();

            // if (choice == "1" || choice == "2" || choice == "3")
            // {
            //     Console.Write("Enter the duration in seconds: ");
            //     if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
            //     {
            //         if (choice == "1")
                    // {
                    //     BreathingActivity breathingActivity = new BreathingActivity(duration);
                    //     breathingActivity.StartActivity();
                    // }
                    // else if (choice == "2")
                    // {
                    //     ReflectionActivity reflectionActivity = new ReflectionActivity(duration);
                    //     reflectionActivity.StartActivity();
                    // }
                    // else
                    // {
                    //     ListingActivity listingActivity = new ListingActivity(duration);
                    //     List<string> items = listingActivity.ListItems();
                    //     Console.WriteLine($"You listed {items.Count} items.");
                    //     listingActivity.StartActivity();
                    // }
                // }
                // else
                // {
                //     Console.WriteLine("Invalid duration. Please enter a positive number.");
                //     Thread.Sleep(2000);
                
        // }
    }
}