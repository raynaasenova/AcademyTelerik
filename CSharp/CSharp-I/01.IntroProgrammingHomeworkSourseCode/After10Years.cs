using System;

class After10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your will be {0} after 10 years.", age + 10);
    }   
}