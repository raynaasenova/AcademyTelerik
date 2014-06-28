using System;

//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

class TheMinimalAndMaximal
{
    static void Main()
    {
        int input;
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;
 
        Console.WriteLine("Enter a caunt n: ");
        int counter = int.Parse(Console.ReadLine());
 
        for (int i = 0; i < counter; i++)
        {
            Console.WriteLine("Enter the {0} number", i + 1);
            input = int.Parse(Console.ReadLine());
 
            if (input > maxValue)
            {
                maxValue = input;
            }
            if (input < minValue)
            {
                minValue = input;
            }
        }
        Console.WriteLine("The minimal is: {0}. The maximal value is {1}.", minValue, maxValue);
    }
}

