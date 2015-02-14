//Write a program that reads two positive integer numbers and prints how many numbers p
//exist between them such that the reminder of the division by 5 is 0.

using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int endNumber = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine("p={0}", p);
    }
}

