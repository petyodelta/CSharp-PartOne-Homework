using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a=" + a);
        Console.WriteLine("b=" + b);
        a += b;
        b = a - b;
        a -= b;
        Console.WriteLine("a=" + a);
        Console.WriteLine("b=" + b);
    }
}

