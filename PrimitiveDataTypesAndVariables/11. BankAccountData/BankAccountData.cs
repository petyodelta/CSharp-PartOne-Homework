using System;

class BankAccountData
{
    static void Main()
    {
        string bankName = "The Bank";
        string firstName = "Ivan";
        string middleName = "Petkov";
        string familyName = "Ivanov";
        string accountHolder = firstName + " " + middleName + " " + familyName;
        string iban = "BG80BNBG96611020345678";
        decimal balance = 1550m;
        ulong creditCard1 = 5555555555555551u;
        ulong creditCard2 = 5555555555555552u;
        ulong creditCard3 = 5555555555555553u;
        Console.WriteLine("Account holder: " + accountHolder);
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Credit card 1 number: " + creditCard1);
        Console.WriteLine("Credit card 2 number: " + creditCard2);
        Console.WriteLine("Credit card 3 number: " + creditCard3);
    }
}

