using System;

//Write a program that calculates N!/K! for given N and K (1<K<N).

    class FactorialDivision
{
    static void Main()
    {
        Console.WriteLine("Enter K > 1");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter N > K");
        int n = int.Parse(Console.ReadLine());

        int result = 1;

        if (1 < k && k < n)
        {
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }

        Console.WriteLine("N!/!K = {0}", result);
    }
}

