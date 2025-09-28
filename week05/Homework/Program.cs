using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment myAssignment = new Assignment("Michael David", "Proportion");
        string summary = "";
        Console.WriteLine("-----------General Assignment Summary---------- -");
        summary = myAssignment.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine("------------Math Assignment Summary-------------");
        MathAssignment myMathAssignment = new MathAssignment("Odafe Erikevwie", "Quadratic Equation", "6.5", "2-14");
        summary = myMathAssignment.GetSummary();
        string mathSummary = myMathAssignment.GetHomeWorkList();
        Console.WriteLine(summary);
        Console.WriteLine(mathSummary);
        Console.WriteLine("--------------Writing Assignment Summary--------------");
        WritingAssignment myWritingAssignment = new WritingAssignment("Benjamin Abraham", "World History", "The Independence of Nigeria");
        summary = myWritingAssignment.GetSummary();
        string writingSummary = myWritingAssignment.GetWritingInformation();
        Console.WriteLine(summary);
        Console.WriteLine(writingSummary);
    }
}