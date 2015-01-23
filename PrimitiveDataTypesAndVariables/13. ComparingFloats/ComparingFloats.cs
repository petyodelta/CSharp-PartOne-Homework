using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter float number a=");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter float number b=");
        double secondNum = double.Parse(Console.ReadLine());
        bool equal = Math.Abs(firstNum - secondNum) < 0.000001;
        Console.WriteLine("The number are equal: " + equal);      
    }
}

