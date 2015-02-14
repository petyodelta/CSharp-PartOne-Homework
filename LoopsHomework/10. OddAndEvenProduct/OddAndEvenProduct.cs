//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[input.Length];
        int oddProduct = 1;
        int evenProduct = 1;
        
        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
            if ((i == 0) || (i % 2 == 0))
            {
                oddProduct *= nums[i];
            }
            else
            {
                evenProduct *= nums[i];
            }
        }
        if (oddProduct == evenProduct)
        {
            int product = oddProduct;
            Console.WriteLine("Yes");
            Console.WriteLine("Product={0}", oddProduct);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Odd_Product={0}", oddProduct);
            Console.WriteLine("Even_Product={0}", evenProduct);
        }
    }
}

