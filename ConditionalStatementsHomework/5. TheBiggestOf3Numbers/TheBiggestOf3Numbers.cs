﻿//Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                Console.WriteLine("Biggest number is {0}", firstNumber);
            }
            else
            {
                Console.WriteLine("Biggest number is {0}", thirdNumber);
            }
        }
        else
        {
            if (secondNumber >= thirdNumber)
            {
                Console.WriteLine("Biggest number is {0}", secondNumber);
            }
            else
            {
                Console.WriteLine("Biggest number is {0}", thirdNumber);
            }
        }
    }
}

