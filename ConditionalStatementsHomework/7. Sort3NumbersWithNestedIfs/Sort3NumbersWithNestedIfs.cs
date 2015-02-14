//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Enter first real number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second real number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third real number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                if (secondNumber >= thirdNumber)
                {
                    Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber);
                }
                else
                {
                    Console.WriteLine(firstNumber + " " + thirdNumber + " " + secondNumber);
                }
            }
            else
            {
                Console.WriteLine(thirdNumber + " " + firstNumber + " " + secondNumber);
            }
        }
        else
	    {
            if (secondNumber >= thirdNumber)
            {
                if (firstNumber >= thirdNumber)
                {
                    Console.WriteLine(secondNumber + " " + firstNumber + " " + thirdNumber);
                }
                else
                {
                    Console.WriteLine(secondNumber + " " + thirdNumber + " " + firstNumber);
                }
            }
            else
            {
                Console.WriteLine(thirdNumber + " " + secondNumber + " " + firstNumber);
            }
	    }
        
    }
}

