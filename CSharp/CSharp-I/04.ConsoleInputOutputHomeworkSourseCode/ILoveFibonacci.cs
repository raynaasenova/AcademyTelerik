using System;
//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class ILoveFibonacci
{
    static void Main()
    {
        decimal n1 = 0m;
        decimal n2 = 1m;
        decimal fib;

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(n1);
            fib = n1 + n2;
            n1 = n2;
            n2 = fib;
        }
    }       
}

