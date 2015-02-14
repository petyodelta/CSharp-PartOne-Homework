//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        bool isOdd = true;
        if ((number % 2) == 0)
        {
            isOdd = false;
            Console.WriteLine("Odd? " + isOdd);
        }
        else
        {
            Console.WriteLine("Odd? " + isOdd);
        }
    }
}

