using System;

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

class CheckPositiveIntegerNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number to 100:");
        int num1 = int.Parse(Console.ReadLine());

        if (num1 == 0 || num1 == 1)
        {
            Console.WriteLine(num1 + " is not prime number");
            Console.ReadLine();
        }
        else
        {
            for (int a = 2; a <= num1 / 2; a++)
            {
                if (num1 % a == 0)
                {
                    Console.WriteLine(num1 + " is not prime number");
                    return;
                }

            }
            Console.WriteLine(num1 + " is a prime number");
            Console.ReadLine();
        }
    }
}


