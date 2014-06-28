using System;
//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. 
//Example: v=5; p=1 -> false.

class ReturnBit
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter p:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int vAndMask = v & mask;
        int bit = vAndMask >> p;
        bool result = bit == 1;
        Console.WriteLine("Is the bit at position {0} = 1? \n{1}", p, result);
    }
}

