using System;

//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

class FibonacciN
{
    static void Main()
    {
        decimal n1 = 0m;
        decimal n2 = 1m;
        decimal f;
        Console.WriteLine("n = ?");
        int input = int.Parse(Console.ReadLine());
        for (int i = 0; i <= input; i++)
			{
			 Console.WriteLine(n1);
            f = n1 + n2;
            n1 = n2;
            n2 = f;
			}
    }
}

