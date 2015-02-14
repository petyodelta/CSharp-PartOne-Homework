//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].


using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random random = new Random();

        for (int i = 0; i < number; i++)
        {
            Console.Write(random.Next(min, max + 1) + " ");
        }
    }
}

