//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter first number a=");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number b=");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine(firstNumber >= secondNumber ? "Greater is " + firstNumber : "Greater is " + secondNumber );
    }
}

