using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
        public List<Entry> _entries;//A list that will hold all the time, prompt questions and responses of the user.
        
        public Journal()//The constructor that initializes the member variable of the Journal class.
        {
            _entries = new List<Entry>();//A new empty list created.
        }
        public void AddEntry(Entry newEntry)//This method creates a new object of the Entry class
        {
            _entries.Add(newEntry);
            Console.WriteLine("Entry successfully added!");
        }
        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("There are no entries to display");
            }
            foreach (Entry userEntry in _entries)//Create a variable userEntry of the Entry type.
            {
                userEntry.Display();
            }
            
        }
        public void SaveToFile(string file)
        {
           
            try
            {
                using (StreamWriter writer = new StreamWriter(file, true))
                {
            
                    foreach (Entry fileEntry in _entries)
                    {
                        writer.WriteLine( fileEntry._date);
                        writer.WriteLine(fileEntry._promptText);
                        writer.WriteLine(fileEntry._entryText);
                        writer.WriteLine(fileEntry._place);
                        writer.WriteLine(fileEntry._motivationalQuote);
        
                    }
                }
                Console.WriteLine($"Your entries have been  saved to the file named {file}");
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Error saving journal");
            }
        }
        public void LoadFromFile(string file)
        {
            _entries.Clear();//Clear out any existing entries before loading from the file

            try
            {
                using (StreamReader fileReader = new StreamReader(file))
                {
                    while (!fileReader.EndOfStream)
                    {
                        string date = fileReader.ReadLine();
                        string prompt = fileReader.ReadLine();
                        string response = fileReader.ReadLine();
                        string placeOfEntry = fileReader.ReadLine();
                        string quote = fileReader.ReadLine();
                        _entries.Add(new Entry(date, prompt, response, placeOfEntry, quote));
                    }
                }
                Console.WriteLine($"Journal successfully loaded from {file}");
            }
            catch (System.Exception)
            {
                
                Console.WriteLine($"File '{file}' not found");
            }
        }
}