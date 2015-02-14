//S= 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;
using System.Numerics;

class CalculateTheFormula
{
    static void Main()
    {
        Console.Write("Enter whole number N=");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter whole number X=");
        int numberX = int.Parse(Console.ReadLine());
        
        decimal sum = 1.00m;
        decimal factoriel = 1.00m;
        decimal xAtPowN = 1.00m;
        
        for (int i = 1; i <= numberN; i++)
        {
            factoriel*= i;
            xAtPowN *= numberX;
            sum += (factoriel / xAtPowN);
        }
        Console.WriteLine("{0:f5}" , sum);
    }
}

