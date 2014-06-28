using System;

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

class Factorial
{
    static void Main()
    {
        Console.WriteLine("Enter value of N > 1");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of K > N");
        int k = int.Parse(Console.ReadLine());

        int result = 1;

        if (1 < n && n < k)
        {
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            for (int i = k - n + 1; i <= k; i++)
            {
                result *= i;
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }

        Console.WriteLine("N!*K! / (K-N)! = {0}", result);
    }
}

