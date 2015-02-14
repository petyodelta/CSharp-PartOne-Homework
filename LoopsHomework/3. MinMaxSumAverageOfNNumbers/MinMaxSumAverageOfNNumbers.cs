//Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter the count of the sequence: ");
        int sequenceNumber = int.Parse(Console.ReadLine());
        
        Console.Write("Enter whole number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        
        int minNumber = firstNumber;
        int maxNumber = firstNumber;
        int sum = firstNumber;
        
        for (int i = 1; i < sequenceNumber; i++)
        {
            Console.Write("Enter whole number: ");
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number < minNumber)
            {
                minNumber = number;
            }
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        double average = sum / (double)sequenceNumber;
        Console.WriteLine("Min number is " + minNumber);
        Console.WriteLine("Max number is " + maxNumber);
        Console.WriteLine("The sum of the numbers is " + sum);
        Console.WriteLine("Average number is {0:f2}", average);
    }
}

