//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix
//holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;


class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int currentRow = 0;
        int currentCol = 0;
        int counter = 1;
        int sideLenght = n;

        while (counter <= n * n)
        {
            //>
            for (int i = 0; i < sideLenght; i++)
            {
                matrix[currentRow, currentCol] = counter;
                currentCol++;
                counter++;
            }

            currentCol--;
            currentRow++;
            sideLenght--;
            //v
            for (int i = 0; i < sideLenght; i++)
            {
                matrix[currentRow, currentCol] = counter;
                currentRow++;
                counter++;
            }

            currentRow--;
            currentCol--;
            //<
            for (int i = 0; i < sideLenght; i++)
            {
                matrix[currentRow, currentCol] = counter;
                currentCol--;
                counter++;
            }

            currentCol++;
            currentRow--;
            sideLenght--;
            //^
            for (int i = 0; i < sideLenght; i++)
            {
                matrix[currentRow, currentCol] = counter;
                currentRow--;
                counter++;
            }
            currentRow++;
            currentCol++;
        }
        //print

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
        }
        Console.WriteLine();
    }
}

