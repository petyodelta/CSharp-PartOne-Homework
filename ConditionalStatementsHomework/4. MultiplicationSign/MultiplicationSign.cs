//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter three real numbers");
        Console.Write("a=");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double thirdNumber = double.Parse(Console.ReadLine());

        if ((firstNumber * secondNumber * thirdNumber) > 0)
        {
            Console.WriteLine("+");
        }
        else if ((firstNumber * secondNumber * thirdNumber) < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}

