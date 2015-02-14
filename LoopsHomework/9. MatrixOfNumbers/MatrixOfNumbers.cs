//Write a program that reads from the console a positive integer number n (1 = n = 20)
//and prints a matrix like in the examples below. Use two nested loops.

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            for (int j = i; j < i + number  ; j++)
            {
                Console.Write("{0,2}" + " ", j);
            }
            Console.WriteLine();
        }
    }
}

