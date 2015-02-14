//Write an if-statement that takes two double variables a and b and exchanges their values
//if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter first variable a=");
        double firstVar = double.Parse(Console.ReadLine());

        Console.Write("Enter second variable b=");
        double secondVar = double.Parse(Console.ReadLine());

        if (firstVar > secondVar)
        {
            firstVar += secondVar;
            secondVar = firstVar - secondVar;
            firstVar -= secondVar;
            Console.WriteLine(firstVar + " " + secondVar);
        }
        else
        {
            Console.WriteLine(firstVar + " " + secondVar);
        }
    }
}
