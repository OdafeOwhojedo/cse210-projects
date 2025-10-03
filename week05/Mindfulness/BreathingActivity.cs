using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;


public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description, int duration ) : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", 60){}
    //public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    
    public void Run()
    {
        DisplayStartMessage();
        var breathingTimer = Stopwatch.StartNew();
        while (breathingTimer.Elapsed.TotalSeconds <_duration)
        {
            Breathe("Breathe in.....", 4);
            Breathe("Hold your breath", 3);
            Breathe("Breathe out.....", 4);
            Breathe("Hold your breath", 3);
        }
        DisplayEndMessage();
    }

    public void Breathe(string breathingMessage, int timeInSeconds)
    {
        for (int i = timeInSeconds; i >= 1; i--)
        {
            Console.Write($"\r {breathingMessage} {i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}