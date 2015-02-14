//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter rectangle width:");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter rectagle height:");
        double height = double.Parse(Console.ReadLine());
        double perimeter = (2 * width) + (2 * height);
        double area = width * height;
        Console.WriteLine("The rectangle perimeter is {0}", perimeter);
        Console.WriteLine("The rectangle area is {0}", area);
    }
}

