//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        BigInteger factorielN = 1;
        BigInteger factorielNPlus1 = 1;
        BigInteger factoriel2N = 1;

        for (int i = 2; i <= (2*numberN); i++)
        {
            if (i <= numberN)
            {
                factorielN *= i;
            }
            if (i <= (numberN+1))
            {
                factorielNPlus1 *= i;
            }
            factoriel2N *= i;
        }
        Console.WriteLine(factoriel2N / (factorielNPlus1 * factorielN));
    }
}

