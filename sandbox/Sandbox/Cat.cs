// Another Derived class
public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public void Meow()
    {
        Console.WriteLine($"{_name} is meowing: Meow!");
    }

    // Override the MakeSound method from the base class
    public override void MakeSound()
    {
        Console.WriteLine($"{_name} is meowing.");
    }
}