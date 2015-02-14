//Write a Boolean expression that returns if the bit at position p (counting from 0,
//starting from the right) in given integer number n, has value of 1.

using System;

class CheckBitAtGivenPosition
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
        bool bitIs1 = (bit == 1);
        Console.WriteLine("bit@p is 1 :{0}",bitIs1);
    }
}

