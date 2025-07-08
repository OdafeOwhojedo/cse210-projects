using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Console.WriteLine("What is your job title?");
        job1._jobTitle = Console.ReadLine();
        Console.WriteLine("What is your company name?");
        job1._companyName = Console.ReadLine();
        Console.WriteLine("Enter the start year.");
        job1._startYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the end year.");
        job1._endYear = int.Parse(Console.ReadLine());
        job1.DisplayJobInfor();
    }
}