using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    
    public Entry(string date, string promptText, string entryText)//The constructor that will initialize the member variables
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt Question: {_promptText}");
        Console.WriteLine($"Your Response: {_entryText}");
    }
}