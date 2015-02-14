//Write an expression that checks if given positive integer number n (n = 100)
//is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter positive integer number lesser than 100: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = false;
        int counter = 0;
        for (int i = 1; i <= number; i++)
        {
            if ((number == 1) || (number > 100))
            {
                break;
            }
            if ((number % i) == 0)
            {
                isPrime = true;
                counter++;
                if (counter > 2)
                {
                    isPrime = false;
                    break;
                }
            }
            else
            {
                isPrime = false;
            }
        }
        Console.WriteLine("Prime? {0}", isPrime);
    }
}

