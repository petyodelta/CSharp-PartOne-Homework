//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string strNumber = Console.ReadLine();
        long number = 0L;
        int pow = strNumber.Length - 1;

        for (int i = 0; i < strNumber.Length; i++)
        {
            number += long.Parse(strNumber[i].ToString()) * (long)Math.Pow(2, pow - i);
        }
        Console.WriteLine(number);
    }
}

