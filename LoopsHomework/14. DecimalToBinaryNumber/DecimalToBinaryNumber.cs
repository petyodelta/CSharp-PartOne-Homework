//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;


class DecimalToBinaryNumber
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string strNumber = string.Empty;

        if (number != 0)
        {
            while (number > 0)
            {
                strNumber += Convert.ToString(number % 2);
                number /= 2;
            }
            for (int i = strNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(strNumber[i]);
            }
        }
        else
        {
            Console.WriteLine(0);
        }
        Console.WriteLine();
    }
}

