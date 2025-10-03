using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;

// public class BaseActivity
// {
//     protected int _duration;
//     protected string _name;
//     protected string _description;

//     public BaseActivity(string name, string description, int duration)
//     {
//         _name = name;
//         _description = description;
//         _duration = duration;
//     }

//     public void StartActivity()
//     {
//         Console.WriteLine($"Prepare to begin {_name} activity: {_description}");
//         Thread.Sleep(3000);
//         for (int i = 1; i <= _duration; i++)
//         {
//             ShowPrompt(i);
//         }
//         EndActivity();
//     }

//     protected abstract void ShowPrompt(int index);

//     private void EndActivity()
//     {
//         Console.WriteLine("You've done a good job!");
//         Console.WriteLine($"You have completed the {_name} activity in {_duration} seconds.");
//         Thread.Sleep(3000);
//     }

//     protected void ShowAnimation()
//     {
//         Console.Write("Loading");
//         for (int i = 0; i < 3; i++)
//         {
//             Thread.Sleep(1000);
//             Console.Write(".");
//         }
//         Console.WriteLine();
//     }
// }
public class Activity 
{
    private string _name;
    private string _description;
    private int _duration;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration; 

    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--------------- {_name}-------------");
        Console.WriteLine(_description);
        Console.WriteLine($"Enter duration in seconds (default {_duration}):    ");
        if (int.TryParse(Console.ReadLine(), out int d))
        {
            _duration = d;

        }
        Console.WriteLine("\nGet ready.....");
        ShowCountDown(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done! You have completed the activity");
        Console.WriteLine("Take a moment to reflect on what you experienced.");
        Console.WriteLine("Please press ENTER to return to the menu");
        Console.ReadLine();
    }

    public void ShowSpinner(int seconds)
    {
        var spinner = new [] {'|', '/', '_', '\\'};
        var spinnerTimer = Stopwatch.StartNew();
        int timeCounter = 0;
        while (spinnerTimer.Elapsed.TotalSeconds < seconds)
        {
            Console.WriteLine(spinner[timeCounter % spinner.Length]);
            Thread.Sleep(150);
            Console.Write('\b');
            timeCounter++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\r Starting in {i}.....");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\r Go!");
    }
}