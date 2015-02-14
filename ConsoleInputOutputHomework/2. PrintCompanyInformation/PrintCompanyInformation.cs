//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter company phone number: ");
        string companyPhone = Console.ReadLine();

        Console.Write("Enter company fax number: ");
        string companyFax = Console.ReadLine();

        Console.Write("Enter company web site: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Enter manager age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Enter manager phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName + "\n" + "Address: " + companyAddress + "\n"
                         + "Tel. :" + companyPhone + "\n" + "Fax: " +companyFax + "\n"
                         + "Web site: " + companyWebSite + "\n"
                         + "Manager: " + managerFirstName + " " + managerLastName
                         + " (age: {0} , tel. {1})", age, managerPhone);
    }
}

