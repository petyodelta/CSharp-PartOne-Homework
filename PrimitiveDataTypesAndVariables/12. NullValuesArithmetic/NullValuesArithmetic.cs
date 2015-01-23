using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? firstNum = null;
        double? secondNum = null;
        Console.WriteLine("First number is !{0}!", firstNum);
        Console.WriteLine("Second number is !{0}! ", secondNum);
        firstNum = 5;
        secondNum = 123.456;
        Console.WriteLine("First number is " + firstNum);
        Console.WriteLine("Second number is " + secondNum);
    }
}

