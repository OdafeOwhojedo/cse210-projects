// 
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _rand;
    public ListingActivity() : base("Listing Activity", "This activity helps you list positive things in your life.")
    {
        _count = 0;
        _prompts = new List<string>{"List people you appreciate.", "List things you are grateful for today.", "List moments when you helped someone recently.", "List things that made you smile this week."};
        _rand = new Random();
    }

    public void Run()
    {
            DisplayStartMessage();
            string promptInstruction = GetRandomPrompt();
            Console.WriteLine($"\nPrompt: {promptInstruction}");
            Console.WriteLine("You have a few seconds to think.....");
            ShowCountDown(5);
            Console.WriteLine("Now, start listing items! Then press ENTER after each entry.");
            List<string> entries = GetListFromUser();
            _count = entries.Count;
            Console.WriteLine($"\nGreat work! You listed {_count} items.");
            DisplayEndMessage();

    }

    public string GetRandomPrompt()
    {
            return _prompts[_rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
            List<string> items = new List<string>();
            var timer = Stopwatch.StartNew();
            while (timer.Elapsed.TotalSeconds < _duration)
            {
                if (Console.KeyAvailable)
                {
                    string newEntry = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newEntry))
                    {
                        items.Add(newEntry);
                    }
                }
                else
                {
                    Thread.Sleep(200);
                }

            }
            return items;
    }
    
}