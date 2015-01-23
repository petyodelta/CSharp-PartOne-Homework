using System;

class PrintAsciiTable
{
    static void Main()
    {
        for(int i = 33; i <= 255; i++)
        {
            char ch = (char)i;
            Console.WriteLine("{0}-> {1}", i, ch);
        }
    }
}

