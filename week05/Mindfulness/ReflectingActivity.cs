// 
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _rand;
    public ReflectingActivity() : base("Reflecting Activity", "This activity helps you reflect on meaningful experiences.")
    {
        _prompts = new List<string>{"Think of a time when you helped someone in need.", "Think of a time when you overcame a challenge.", "Think of a time when you felt inspired.", "Think of a time when you learned something new about yourself."};
        _questions = new List<string>{"Why was this experience meaningful to you?", "What did you learn about yourself from it?", "How can you apply this lesson to your daily life?", "What did you feel during this experience?"};
        _rand = new Random();
    }

    public void Run()
    {
        DisplayStartMessage();
        DisplayPrompt();
        ShowCountDown(5);
        var timer = Stopwatch.StartNew();
        while (timer.Elapsed.TotalSeconds < _duration)
        {
            DisplayQuestion();
            ShowSpinner(9);
        }
        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];

    }

    public string GetRandomQuestion()
    {
        return _questions[_rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"Your question: {question}");
    }
}
