using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company address");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Phone number:");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Fax number:");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Web site:");
        string webSite = Console.ReadLine();
        Console.WriteLine("Manager first name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Manager last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Manager age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Manager phone:");
        string managerPhone = Console.ReadLine();
        //Print
        Console.WriteLine("\n{0}", companyName);
        Console.WriteLine("Address: {0}",companyAddress);
        Console.WriteLine("Tel: {0}", phoneNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age:{2}, tel. {3})", firstName, lastName, age, managerPhone);
    }
}

