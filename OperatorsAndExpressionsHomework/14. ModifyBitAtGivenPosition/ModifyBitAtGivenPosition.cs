//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n
//to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter integer number n=");
        int number = int.Parse(Console.ReadLine());
        
        Console.Write("Enter bit position p=");
        int position = int.Parse(Console.ReadLine());
        
        Console.Write("Enter value 0 or 1 v=");
        int value = int.Parse(Console.ReadLine());

        int result = 0;
        
        if (value == 1)
        {
            int mask = 1 << position;
            result = number | mask;
            Console.WriteLine("Result: {0}", result);
        }
        else
        {
            int mask = ~(1 << position);
            result = number & mask;
            Console.WriteLine("Result: {0}", result);
        }
    }
}

