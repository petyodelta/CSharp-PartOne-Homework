/*Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
 Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
 */

using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        for (int i1 = 2; i1 <= 14; i1++)
        {
            for (int i2 = 1; i2 <= 4; i2++)
            {
                switch (i1)
                {
                    case 2:
                        Console.Write(i1);
                        break;
                    case 3:
                        Console.Write(i1);
                        break;
                    case 4:
                        Console.Write(i1);
                        break;
                    case 5:
                        Console.Write(i1);
                        break;
                    case 6:
                        Console.Write(i1);
                        break;
                    case 7:
                        Console.Write(i1);
                        break;
                    case 8:
                        Console.Write(i1);
                        break;
                    case 9:
                        Console.Write(i1);
                        break;
                    case 10:
                        Console.Write(i1);
                        break;
                    case 11:
                        Console.Write("A");
                        break;
                    case 12:
                        Console.Write("J");
                        break;
                    case 13:
                        Console.Write("D");
                        break;
                    case 14:
                        Console.Write("K");
                        break;
                    default:
                        break;
                }
                switch (i2)
                {
                    case 1:
                        Console.Write(" of spades, ");
                        break;
                    case 2:
                        Console.Write(" of hearts, ");
                        break;
                    case 3:
                        Console.Write(" of hearts, ");
                        break;
                    case 4:
                        Console.WriteLine(" of diamonds");
                        break;
                    default:
                        break;
                }

            }
        }
    }
}

