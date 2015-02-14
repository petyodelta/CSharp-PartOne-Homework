//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Enter integer number:");
        int number = int.Parse(Console.ReadLine());
        int checkNumber = number / 100;
        int thirdDigit = checkNumber % 10;
        bool isTrue = (thirdDigit == 7);
        Console.WriteLine("The third digit is 7: {0}", isTrue);
    }
}

