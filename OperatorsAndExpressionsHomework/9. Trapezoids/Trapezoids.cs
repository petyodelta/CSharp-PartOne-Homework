//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter trapezoid side a=");
        double a = double.Parse(Console.ReadLine());
        
        Console.Write("Enter trapezoid side b=");
        double b = double.Parse(Console.ReadLine());
        
        Console.Write("Enter trapezoid height h=");
        double h = double.Parse(Console.ReadLine());
        
        double area = ((a + b) / 2) * h;
        Console.WriteLine("Area is {0}", area);
    }
}

