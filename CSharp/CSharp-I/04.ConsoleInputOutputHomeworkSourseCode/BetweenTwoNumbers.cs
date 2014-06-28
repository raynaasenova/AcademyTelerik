using System;

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

class BetweenTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer number: ");
        string inputA = Console.ReadLine();
        int a = int.Parse(inputA);

        Console.WriteLine("Enter the second integer number: ");
        string inputB = Console.ReadLine();
        int b = int.Parse(inputB);
        
        int counter = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        } 
        Console.WriteLine("{0} numbers between {1} and {2}.", counter, a, b);
    }
}   