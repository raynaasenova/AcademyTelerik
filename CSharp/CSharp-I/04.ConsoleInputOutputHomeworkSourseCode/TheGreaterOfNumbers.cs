using System;

//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

    class TheGreaterOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number a:");
        string inputA = Console.ReadLine();
        int a = int.Parse(inputA);
        Console.WriteLine("Enter the second number b:");
        string inputB = Console.ReadLine();
        int b = int.Parse(inputB);
        Console.WriteLine("The greater number is: {0}", Math.Max(a, b));
    }
}

