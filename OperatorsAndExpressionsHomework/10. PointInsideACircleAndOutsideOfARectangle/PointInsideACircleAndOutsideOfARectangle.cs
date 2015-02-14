//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.Write("Enter point coordinate x=");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter point coordinate y=");
        double y = double.Parse(Console.ReadLine());

        double radius = 1.5;
        bool isInCircle = (( x - 1 ) * ( x -1 )) + ((y - 1) * (y -1 )) <= (radius * radius);

        bool isOutRectangle = ((x < -1) || (x > 5)) || ((y < -1) || (y > 1));
        
        if (isInCircle && isOutRectangle)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
     }
}

