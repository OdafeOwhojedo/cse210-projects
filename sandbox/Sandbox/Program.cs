using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Sandbox Project.");
        // Create an instance of the base class
        Animal genericAnimal = new Animal("Generic Animal");
        genericAnimal.Eat();
        genericAnimal.MakeSound();
        Console.WriteLine();

        // Create an instance of the derived class Dog
        Dog myDog = new Dog("Buddy", "Golden Retriever");
        myDog.Eat();       // Inherited from Animal
        myDog.Bark();      // Specific to Dog
        myDog.MakeSound(); // Overridden in Dog
        Console.WriteLine();

        // Create an instance of the derived class Cat
        Cat myCat = new Cat("Whiskers");
        myCat.Eat();       // Inherited from Animal
        myCat.Meow();      // Specific to Cat
        myCat.MakeSound(); // Overridden in Cat


    }
}