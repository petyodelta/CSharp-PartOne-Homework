//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter positive whole number n=");
        uint number = uint.Parse(Console.ReadLine());
        
        byte bitCheck1 = 3;
        byte bitCheck2 = 24;
        
        for (int i = 0; i < 3; i++)
        {
            uint mask1 = (number & (1u << bitCheck1)) >> bitCheck1;
            uint mask2 = (number & (1u << bitCheck2)) >> bitCheck2;

            if (mask1 == 1)
            {
                number = number | (1u << bitCheck2);
            }
            else
            {
                number = number & (~(1u << bitCheck2));
            }
            if (mask2 == 1)
            {
                number = number | (1u << bitCheck1);
            }
            else
            {
                number = number & (~(1u << bitCheck1));
            }
            bitCheck1++;
            bitCheck2++;
        }
        Console.WriteLine("Result: {0}", number);
    }
}

