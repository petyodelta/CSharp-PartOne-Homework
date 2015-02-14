//Write an expression that extracts from given integer n the value of given bit at index p

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter integer number n=");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter bit index p=");
        int bitIndex = int.Parse(Console.ReadLine());

        int mask = 1 << bitIndex;

        int numberAndMask = number & mask;
        int bit = numberAndMask >> bitIndex;
        Console.WriteLine("bit@p is {0}", bit);
    }
}

