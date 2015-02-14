//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("Enter positive whole number: ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << 3;
        int maskAndNumber = number & mask;
        int bit = maskAndNumber >> 3;
        Console.WriteLine("bit@3 is {0}", bit);
    }
}

