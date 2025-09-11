using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _place;
    public string _motivationalQuote;
    
    public Entry(string date, string promptText, string entryText, string place, string motivationalQuote)//The constructor that will initialize the member variables
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _place = place;
        _motivationalQuote = motivationalQuote;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt Question: {_promptText}");
        Console.WriteLine($"Your Response: {_entryText}");
        Console.WriteLine($"Location of entry: {_place}");
        Console.WriteLine($"Your motivational quote: {_motivationalQuote}");
    }
}