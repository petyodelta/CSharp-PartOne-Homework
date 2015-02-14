//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
//Try to use only two loops.

using System;
using System.Numerics;


class CalculateTheFormula
{
    static void Main()
    {
        Console.Write("Enter n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k=");
        int k = int.Parse(Console.ReadLine());
        
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;

        for (int i = n; i >= 2; i--)
        {
            factorialN *= i;
            if (k >= i)
            {
                factorialK *= i;
            }
        }
        for (int i = 2; i <= (n - k); i++)
        {
            factorialNK *= i;
        }
        Console.WriteLine("N!/(K!*(N-K)!={0}",factorialN/(factorialK * factorialNK));
    }
}


