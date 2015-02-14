//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.


using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter positive whole number n=");
        uint number = uint.Parse(Console.ReadLine());

        Console.Write("Enter bit position p=");
        byte bitCheckP = byte.Parse(Console.ReadLine());

        Console.Write("Enter bit position q=");
        byte bitCheckQ = byte.Parse(Console.ReadLine());

        Console.Write("Enter number k=");
        byte k = byte.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            uint mask1 = (number & (1u << bitCheckP)) >> bitCheckP;
            uint mask2 = (number & (1u << bitCheckQ)) >> bitCheckQ;

            if (mask1 == 1)
            {
                number = number | (1u << bitCheckQ);
            }
            else
            {
                number = number & (~(1u << bitCheckQ));
            }
            if (mask2 == 1)
            {
                number = number | (1u << bitCheckP);
            }
            else
            {
                number = number & (~(1u << bitCheckP));
            }
            bitCheckP++;
            bitCheckQ++;
        }
        Console.WriteLine("Result: {0}", number);
    }
}

