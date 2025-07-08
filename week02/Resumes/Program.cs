using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Console.Write("What is your job title?  ");
        job1._jobTitle = Console.ReadLine();
        Console.Write("What is your company name?  ");
        job1._companyName = Console.ReadLine();
        Console.Write("Enter the start year.  ");
        job1._startYear = int.Parse(Console.ReadLine());
        Console.Write("Enter the end year.  ");
        job1._endYear = int.Parse(Console.ReadLine());
        job1.DisplayJobInfor();
        Job job2 = new Job();
        Console.Write("What is your job title?  ");
        job2._jobTitle = Console.ReadLine();
        Console.Write("What is your company name?  ");
        job2._companyName = Console.ReadLine();
        Console.Write("Enter the start year.  ");
        job2._startYear = int.Parse(Console.ReadLine());
        Console.Write("Enter the end year.  ");
        job2._endYear = int.Parse(Console.ReadLine());
        job2.DisplayJobInfor();

    }
}