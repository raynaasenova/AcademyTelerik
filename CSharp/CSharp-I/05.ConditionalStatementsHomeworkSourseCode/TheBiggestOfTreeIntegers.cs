using System;

//Write a program that finds the biggest of three integers using nested if statements.

class TheBiggestOfTreeIntegers
{
    static void Main()
    {
        Console.WriteLine("Please, enter three integer numbers:");
        string inputA = Console.ReadLine();
        int a = int.Parse(inputA);
        
        string inputB = Console.ReadLine();
        int b = int.Parse(inputB);
        
        string inputC = Console.ReadLine();
        int c = int.Parse(inputC);
        
        if (a == b && a == c && b == c)
        {
            Console.WriteLine("The numbers is equally.");
        }
        else if (a > b && a > c)
        {
            Console.WriteLine("{0} is bigger.", a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("{0} is bigger.", b);
        }
        else if (c > a && c > b)
        {
            Console.WriteLine("{0} is bigger.", c);
        }
    }
}

