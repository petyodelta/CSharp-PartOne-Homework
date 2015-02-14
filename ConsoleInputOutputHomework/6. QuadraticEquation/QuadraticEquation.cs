//Write a program that reads the coefficients a, b and c of a quadratic equation
//ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficient a=");
        double coeffA = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient b=");
        double coeffB = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient c=");
        double coeffC = double.Parse(Console.ReadLine());
        
        double root1 = 0;
        double root2 = 0;
        double discriminant = (coeffB * coeffB) - (4 * coeffA * coeffC);
        
        if (discriminant > 0)
        {
            root1 = ((-coeffB) + (Math.Sqrt(discriminant))) / (2 * coeffA);
            root2 = ((-coeffB) - (Math.Sqrt(discriminant))) / (2 * coeffA);
            Console.WriteLine("Two real roots: x1={0}; x2={1}", root1, root2); 
        }
        else if (discriminant == 0)
        {
            root1 = root2 = -(coeffB / (2 * coeffA));
            Console.WriteLine("One real root: x1=x2={0}", root1);
        }
        else
        {
            Console.WriteLine("There are no real roots.");
        }
    }
}

