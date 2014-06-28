using System;

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

class InformationOfManager
{
    static void Main()
    {
        string companyName, firstName, lastName, address, webSite;
        int age, phoneNumber, faxNumber;

        Console.WriteLine("Enter a company name:");
        companyName = Console.ReadLine(); //{0}

        Console.WriteLine("Enter the first name of the manager:");
        firstName = Console.ReadLine(); //{1}

        Console.WriteLine("Enter the last name of the manager:");
        lastName = Console.ReadLine(); 

        Console.WriteLine("Enter an address:"); 
        address = Console.ReadLine();
        
        Console.WriteLine("Enter a website:"); 
        webSite = Console.ReadLine(); 
        
        Console.WriteLine("Enter an age:");
        string inputAge = Console.ReadLine(); 
        age = int.Parse(inputAge);
        
        Console.WriteLine("Enter a phone number:");
        string inputphoneNumber = Console.ReadLine(); 
        phoneNumber = int.Parse(inputphoneNumber);

        Console.WriteLine("Enter a fax number:");
        string inputFaxNumber = Console.ReadLine(); 
        faxNumber = int.Parse(inputFaxNumber);
        Console.WriteLine();
        Console.WriteLine("=============================================");
        Console.WriteLine();
        Console.WriteLine("Information about the manager of the company:"); 
        Console.WriteLine("Company name: {0}", companyName);
        Console.WriteLine("The first name of the manager: {0}", firstName);
        Console.WriteLine("The last name of the manager: {0}", lastName);
        Console.WriteLine("Address: {0}", address);
        Console.WriteLine("Website: ", webSite);
        Console.WriteLine("Age: ", age);
        Console.WriteLine("Phone number: ", phoneNumber);
        Console.WriteLine("Fax nymber", faxNumber);
        Console.WriteLine();
        Console.WriteLine("=============================================");
           }
}

