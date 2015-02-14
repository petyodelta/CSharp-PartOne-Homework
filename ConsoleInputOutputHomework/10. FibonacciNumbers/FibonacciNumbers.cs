//Write a program that reads a number n and prints on the console the first n members
//of the Fibonacci sequence (at a single line, separated by comma and 
//space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter number n=");
        decimal number = decimal.Parse(Console.ReadLine());
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal nNumber = firstNumber + secondNumber;
        if (number == 1)
        {
            Console.WriteLine(firstNumber);
        }
        else if (number == 2)
        {
            Console.WriteLine(firstNumber + " ," + secondNumber);
        }
        else if (number > 2)
        {
            Console.Write(firstNumber + " ," + secondNumber + " ," + nNumber);
            for (int i = 3; i < number; i++)
            {
                firstNumber = secondNumber;
                secondNumber = nNumber;
                nNumber = firstNumber + secondNumber;
                Console.Write(" ," + nNumber);
            }
        }        
    }
}

