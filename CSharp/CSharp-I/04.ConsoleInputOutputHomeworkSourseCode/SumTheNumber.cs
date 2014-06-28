using System;

//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

class SumTheNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the number count: ");
        
        long sum = 0;
        uint n = uint.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            sum += input;
        }
        Console.WriteLine("The Sum is: {0}", sum);
    }
}

