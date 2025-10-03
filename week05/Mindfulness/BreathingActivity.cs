using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;


public class BreathingActivity : Activity
{
    // public BreathingActivity(int duration) : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration) { }

    // protected override void ShowPrompt(int index)
    // {
    //     if (index % 2 == 1)
    //         Console.WriteLine("Breathe in...");
    //     else
    //         Console.WriteLine("Breathe out...");
    //     ShowAnimation();
    //     Thread.Sleep(1000);
    // }
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing exercise", 60){}
    
    public void Run()
    {
        DisplayStartMessage();
        var breathingTimer = Stopwatch.StartNew();
        while (breathingTimer.Elapsed.TotalSeconds < _duration)
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