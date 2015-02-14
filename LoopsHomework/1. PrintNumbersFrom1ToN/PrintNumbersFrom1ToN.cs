//Write a program that enters from the console a positive integer n and prints
//all the numbers from 1 to n, on a single line, separated by a space.

using System;

class PrintNumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter positive whole number: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

