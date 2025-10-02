using System;

// Base class (Parent Class)
public class Animal
{
    public string _name { get; set; }

    public Animal(string name)
    {
        _name = name;
    }

    public void Eat()
    {
        Console.WriteLine($"{_name} is eating.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{_name} makes a generic sound.");
    }
}
