
using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _rand;
    public ReflectingActivity(string name, string description, int duration ) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 60)
    {
        _prompts = new List<string>{"Think of a time when you helped someone else.", "Think of a time when you did something difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
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
            Console.WriteLine("> Your answer:  ");
            string response = Console.ReadLine();
            ShowSpinner(1);

            
        
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
