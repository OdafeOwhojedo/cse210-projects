
using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _rand;
    public ListingActivity(string name, string description, int duration) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", 60)
    {
        _count = 0;
        _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
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