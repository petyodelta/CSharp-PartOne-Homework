//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.


using System;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("Enter 5 integer numbers separated by space:");
        string[] input = Console.ReadLine().Split(' ');

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        int d = int.Parse(input[3]);
        int e = int.Parse(input[4]);
        
        //Sum of 2 numbers
        if (a + b == 0)
        {
            Console.WriteLine("{0}+{1}=0",a , b);
        }
        if (a + c == 0)
        {
           Console.WriteLine("{0}+{1}=0",a , c); 
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0}+{1}=0",a , d);
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0}+{1}=0",a , e);
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0}+{1}=0",b , c);
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0}+{1}=0",b , d);
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0}+{1}=0",b , e);
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0}+{1}=0",c , d);
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0}+{1}=0",c , e);
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0}+{1}=0",d , e);
        }
        //Sum of 3 numbers
        if (a + b +c == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",a , b, c);
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",a , b, d);
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",a , b, e);
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",a , c, d);
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",a , c, e);
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",a , d, e);
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",b , c, d);
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",b , c, e);
        }
        if (b + d + e ==0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",b , d, e);
        }
        if (c + d + e ==0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",c , d, e);
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",c , d, e);
        }
        //Sum of 4 numbers
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}=0",a , b, c, d);
        }
        if (a + b + c +e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}=0",a , b, c, e);
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}=0",a , b, d, e);
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}=0",a , c, d, e);
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}=0",b, c, d, e);
        }
        //Sum of 5 numbers
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}+{4}=0", a, b, c, d, e);
        }
    }
}

