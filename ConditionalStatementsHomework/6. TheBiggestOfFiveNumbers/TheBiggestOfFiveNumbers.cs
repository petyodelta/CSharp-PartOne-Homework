//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());

        double biggestNumber;

        if (firstNumber >= secondNumber)
        {
            biggestNumber = firstNumber;
        }
        else
        {
            biggestNumber = secondNumber;
        }

        if (thirdNumber >= biggestNumber)
        {
            biggestNumber = thirdNumber;
        }

        if (fourthNumber >= biggestNumber)
        {
            biggestNumber = fourthNumber;
        }

        if (fifthNumber >= biggestNumber)
        {
            biggestNumber = fifthNumber;
        }
        Console.WriteLine("Biggest number is {0}", biggestNumber);
    }
}

