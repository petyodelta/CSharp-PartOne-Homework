//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter point coordinate x=");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter point coordinate y=");
        double y = double.Parse(Console.ReadLine());
        int radius = 2;
        bool isInCircle = ((x * x) + (y * y) <= (radius * radius));
        Console.WriteLine("Inside? {0}", isInCircle);
    }
}

