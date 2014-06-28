using System;

//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

class CheckBit3_2
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number:");
        int p = 5;
        int n = int.Parse(Console.ReadLine());
        int therdBit = n >> p;
        int bit = therdBit & 1;
        bool result = bit == 1;
        Console.WriteLine("The bit 3 is 1. \n{0}", result);        
    }
}

