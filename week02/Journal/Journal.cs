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
            foreach (Entry myEntry in _entries)//Create a variable myEntry of the Entry type.
            {
                myEntry.Display();
            }
            
        }
        public void SaveToFile(string file)
        {
           
            try
            {
                using (StreamWriter writer = new StreamWriter(file, true))
                {
            
                    foreach (Entry entry in _entries)
                    {
                        writer.WriteLine( entry._date);
                        writer.WriteLine(entry._promptText);
                        writer.WriteLine(entry._entryText);
        
                    }
                }
                Console.WriteLine($"Your enteries have been  saved to the file named {file}");
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
                using (StreamReader newReader = new StreamReader(file))
                {
                    while (!newReader.EndOfStream)
                    {
                        string date = newReader.ReadLine();
                        string prompt = newReader.ReadLine();
                        string response = newReader.ReadLine();
                        _entries.Add(new Entry(date, prompt, response));
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