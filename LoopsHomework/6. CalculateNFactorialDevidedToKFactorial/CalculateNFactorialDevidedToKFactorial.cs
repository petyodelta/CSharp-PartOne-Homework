//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;


class CalculateNFactorialDevidedToKFactorial
{
    static void Main()
    {
        Console.Write("Enter n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k=");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        
        for (int i = n; i >= 2; i--)
        {
            factorialN *= i;
            if(k >= i)
            {
                factorialK*= i;
            }
        }
        Console.WriteLine("n!/k!={0}",factorialN / factorialK);
    }
}

