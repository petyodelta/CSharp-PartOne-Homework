//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter integer number:");
        int number = int.Parse(Console.ReadLine());
        bool devideBy5 = (number % 5) == 0;
        bool devideBy7 = (number % 7) == 0;
        Console.WriteLine("Divided by 7 and 5 without remaider? {0}", devideBy5 && devideBy7);      
    }
}

