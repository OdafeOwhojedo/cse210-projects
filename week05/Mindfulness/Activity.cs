using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;

public class Activity 
{
    private string _name;
    private string _description;
    protected int _duration;

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
        _duration = duration = 60; 

    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--------------- {_name}---------------");
        Console.WriteLine(_description);
        Console.WriteLine($"Enter duration in seconds (default {_duration}):    ");
        if (int.TryParse(Console.ReadLine(), out int dueTime))
        {
            _duration = dueTime;

        }
        Console.WriteLine("\nGet ready.....");
        ShowCountDown(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Congratulations and well done!");
        ShowLastCountDown(10);
        Console.WriteLine();
        Console.WriteLine($"You just completed the {_name} for {_duration} seconds");
        Console.WriteLine("Take a moment to reflect on what you experienced.");
        Thread.Sleep(6000);
        ShowSpinner(2);
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

    public void ShowLastCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\r {i}.....");
            Thread.Sleep(1000);
        }
        
    }
}