using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
       int enteredNumber = -1;
       while(enteredNumber != 0)
       {
        Console.Write("Enter a number to be added or zero(0) to quit  ");
        enteredNumber = int.Parse(Console.ReadLine());
        numbers.Add(enteredNumber);
       }
       int total = 0;
       foreach (int  number in numbers)
       {
        total += number;
       }
       Console.WriteLine($"The total is: {total}");
       float average;
       int numberCounted = numbers.Count;
       average = total/numberCounted;
       Console.WriteLine($"The average is: {average}");
       int highestNumber = 0;
       foreach(int maxNumber in numbers)
       {
        if (maxNumber > highestNumber)
        highestNumber = maxNumber;
       }
       Console.Write($"The highest number in the list is: {highestNumber}");

    }
}