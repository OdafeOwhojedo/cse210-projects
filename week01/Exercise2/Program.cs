using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?  ");
        string grade = Console.ReadLine();
        int userGrade = int.Parse(grade);
        string letter = "";
        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";
        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (userGrade >= 70)
        {
            Console.WriteLine($"Congratulations! your grade is {letter}, you passed!");

        }
        else
        {
            Console.WriteLine($"Sorry your grade is {letter} and you failed the course, but you can try again.");
        }

        
    }
}