using System;

//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

class CheckBit3
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number:");
        int p = 3;
        int n = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        bool result = bit == 1;
        Console.WriteLine("The bit 3 is 1. \n{0}", result);
   }
}

