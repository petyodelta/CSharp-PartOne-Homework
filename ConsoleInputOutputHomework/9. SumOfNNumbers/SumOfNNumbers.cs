//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter number n=");
        int numberN = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < numberN; i++)
        {
            Console.Write("Enter number: ");
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("Sum={0}", sum);
    }
}

