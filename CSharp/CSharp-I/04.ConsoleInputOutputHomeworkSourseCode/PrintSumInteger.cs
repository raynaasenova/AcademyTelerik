using System;

//Write a program that reads 3 integer numbers from the console and prints their sum.

class PrintSumInteger
{
    static void Main()
    {       
        Console.Write("Enter the first integer number a:");
        string input1 = Console.ReadLine();
        int a = int.Parse(input1);
                 
        Console.Write("Enter the second integer number b:");
        string input2 = Console.ReadLine();
        int b = int.Parse(input2);

        Console.Write("Enter the third integer number c:");
        string input3 = Console.ReadLine();
        int c = int.Parse(input3);
        
        int sumABC = a + b + c;
        Console.WriteLine("The sum of {0} + {1} + {2} is {3}.", a, b, c, sumABC);      
    }
}

