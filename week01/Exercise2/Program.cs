using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?  ");
        string grade = Console.ReadLine();
        int userGrade = int.Parse(grade);
        if (userGrade >= 90)
        {
            Console.WriteLine("Your grade is A");
            Console.Write("Congratulations! you pass");
        }
        else if (userGrade >= 80)
        {
            Console.WriteLine("Your grade is B");
            Console.Write("Congratulations! You pass");
        }
        else if (userGrade >= 70)
        {
            Console.WriteLine("Your grade is C");
            Console.Write("Congratulations! You pass");
        }
        else if (userGrade >= 60)
        {
            Console.WriteLine("Your grade is D");
            Console.Write("Congratulations! You passed");
        }
        else
        {
            Console.WriteLine("Your grade is F");
            Console.Write("Sorry, you failed the course, please try again.");
        }

        
    }
}