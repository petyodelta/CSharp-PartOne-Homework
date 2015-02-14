//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string strNumber = string.Empty;
        if (number != 0)
        {
            while (number > 0)
            {
                long remainder = number % 16;
                number /= 16;
                switch (remainder)
                {
                    case 10:
                        strNumber += 'A';
                        break;
                    case 11:
                        strNumber += 'B';
                        break;
                    case 12:
                        strNumber += 'C';
                        break;
                    case 13:
                        strNumber += 'D';
                        break;
                    case 14:
                        strNumber += 'E';
                        break;
                    case 15:
                        strNumber += 'F';
                        break;
                    default:
                        strNumber += remainder.ToString();
                        break;
                }
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

