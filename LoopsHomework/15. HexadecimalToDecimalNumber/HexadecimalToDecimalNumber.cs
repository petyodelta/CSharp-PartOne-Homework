//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string strNumber = Console.ReadLine();
        long number = 0L;
        int hexDidits = 0;
        int pow = strNumber.Length - 1;

        for (int i = 0; i < strNumber.Length; i++)
        {
            
            switch(strNumber[i])
            {
                case 'A':
                    hexDidits = 10;
                    break;
                case 'B':
                    hexDidits = 11;
                    break;
                case 'C':
                    hexDidits = 12;
                    break;
                case 'D':
                    hexDidits = 13;
                    break;
                case 'E':
                    hexDidits = 14;
                    break;
                case 'F':
                    hexDidits = 15;
                    break;
                default:
                    hexDidits = int.Parse(strNumber[i].ToString());
                    break;
            }
            number += hexDidits * (long)Math.Pow(16, pow - i);
        }
            Console.WriteLine(number);     
    }
}

