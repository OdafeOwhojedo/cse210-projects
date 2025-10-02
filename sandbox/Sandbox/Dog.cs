// Derived class (Child Class)
public class Dog : Animal
{
    public string _breed { get; set; }

    public Dog(string name, string breed) : base(name) // Call base class constructor
    {
        _breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine($"{_name} (a {_breed}) is barking: Woof! Woof!");
    }

    // Override the MakeSound method from the base class
    public override void MakeSound()
    {
        Console.WriteLine($"{_name} (a {_breed}) is barking.");
    }
}