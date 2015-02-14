//Write a program that enters 5 numbers (given in a single line, separated by a space),
//calculates and prints their sum.

//Write a program that enters 5 numbers (given in a single line, separated by a space),
//calculates and prints their sum.

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter 5 numbers separated by space:");
        string[] input = Console.ReadLine().Split(' ');

        double firstNumber = double.Parse(input[0]);
        double secondNumber = double.Parse(input[1]);
        double thirdNumber = double.Parse(input[2]);
        double fourthNumber = double.Parse(input[3]);
        double fifthNumber = double.Parse(input[4]);

        double sum = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;
        Console.WriteLine("Sum={0}", sum);
    }
}

