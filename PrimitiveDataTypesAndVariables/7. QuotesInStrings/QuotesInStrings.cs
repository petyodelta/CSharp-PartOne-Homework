﻿using System;

class QuotesInStrings
{
    static void Main()
    {
        string str1 = "The \"use\" of quotations causes difficulties.";
        string str2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}

