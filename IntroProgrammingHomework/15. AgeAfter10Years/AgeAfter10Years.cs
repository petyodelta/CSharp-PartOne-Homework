using System;


class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your birthday date (dd/mm/yyyy): ");
        DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
        DateTime todayDate = DateTime.Today;
        int age = 0;
        if (todayDate.Month > birthDate.Month)
        {
            age = todayDate.Year - birthDate.Year;
        }
        else if (todayDate.Month < birthDate.Month)
        {
            age = todayDate.Year - birthDate.Year - 1;
        }
        else if (todayDate.Day >= birthDate.Day)
        {
            age = todayDate.Year - birthDate.Year;
        }
        else
        {
            age = todayDate.Year - birthDate.Year - 1;
        }
        Console.WriteLine("You are {0} years old. In ten years you will be {1} years old."
                , age, age + 10);
    }
} 
