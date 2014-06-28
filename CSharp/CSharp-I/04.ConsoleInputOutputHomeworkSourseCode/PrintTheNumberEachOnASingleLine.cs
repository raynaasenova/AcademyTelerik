using System;

//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

class PrintTheNumberEachOnASingleLine
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string inputA = Console.ReadLine();
        sbyte a = sbyte.Parse(inputA);

        if (a > 0)
        {
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = 1; i >= a; i--)
            {
                Console.WriteLine(i);
            }
        }

    }
}

