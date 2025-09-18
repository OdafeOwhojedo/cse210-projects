using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        float radius = 0;
        double area;
        double perimeter;
        Console.Write("Enter the value of the radius of the circle:    ");
        radius = float.Parse(Console.ReadLine());
        Circle myCircle = new Circle(radius);
        area = myCircle.AreaOfCircle();
        perimeter = myCircle.PerimeterOfCircle();
        Console.WriteLine($"The Area of the circle is:  {area}");
        Console.WriteLine($"The Perimeter of the Circle is:   {perimeter}");


    }
}