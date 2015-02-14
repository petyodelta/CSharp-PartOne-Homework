//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.


using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("1 -> int");
        Console.WriteLine("2 -> double");
        Console.WriteLine("3 -> string");
        Console.Write("Please choose a type:");
        
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.Write("Please enter an integer:");
                int intNumber = int.Parse(Console.ReadLine());
                intNumber++;
                Console.WriteLine(intNumber); 
                break;
            case "2":
                Console.Write("Please enter a double:");
                double doubleNumber = double.Parse(Console.ReadLine());
                doubleNumber++;
                Console.WriteLine(doubleNumber); 
                break;
            case "3":
                Console.Write("Please enter a string:");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*"); 
                break;
            default:
                Console.WriteLine("Ivalid choice!"); 
                break;
        }
    }
}

