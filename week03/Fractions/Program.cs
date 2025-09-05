using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstFraction = new Fraction();
        string displayStringResult;
        double displayDecimalResult;
        displayStringResult = firstFraction.GetFraction();
        displayDecimalResult = firstFraction.GetDecimalValue();
        Console.WriteLine(displayStringResult);
        Console.WriteLine(displayDecimalResult);
        int userNumber;
        Console.Write("Enter the numerator of your fraction:   ");
        userNumber = int.Parse(Console.ReadLine());
        Fraction secondFraction = new Fraction(userNumber);
        displayStringResult = secondFraction.GetFraction();
        displayDecimalResult = secondFraction.GetDecimalValue();
        Console.WriteLine(displayStringResult);
        Console.WriteLine(displayDecimalResult);
        int userNumerator;
        int userDenominator;
        Console.Write("Enter any number for the numerator other than zero(0) for your fraction:   ");
        userNumerator = int.Parse(Console.ReadLine());
        Console.Write("Enter any number for the denominator other than zero(0) for your fraction:   ");
        userDenominator = int.Parse(Console.ReadLine());
        Fraction thirdFraction = new Fraction(userNumerator, userDenominator);
        displayStringResult = thirdFraction.GetFraction();
        displayDecimalResult = thirdFraction.GetDecimalValue();
        Console.WriteLine(displayStringResult);
        Console.WriteLine(displayDecimalResult);
        Console.Write("Enter any number for the numerator except zero(0) for your fraction:   ");
        userNumerator = int.Parse(Console.ReadLine());
        Console.Write("Enter any number for the denominator except zero(0) for your fraction:   ");
        userDenominator = int.Parse(Console.ReadLine());
        Fraction fourthFraction = new Fraction(userNumerator, userDenominator);
        fourthFraction.SetTop(userNumerator);
        fourthFraction.SetBottom(userDenominator);
        displayStringResult = fourthFraction.GetFraction();
        displayDecimalResult = fourthFraction.GetDecimalValue();
        Console.WriteLine(displayStringResult);
        Console.WriteLine(displayDecimalResult);
        int confirmNumerator;
        int confirmDenominator;
        confirmNumerator = fourthFraction.GetTop();
        Console.WriteLine($"The numerator of the fraction is:  {confirmNumerator}");
        confirmDenominator = fourthFraction.GetBottom();
        Console.WriteLine($"The denominator of the fraction is:  {confirmDenominator}");

    }
}