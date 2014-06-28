using System;
//We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
//n = 5 (00000101), p=2, v=0 -> 1 (00000001)

class ModifyBit
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number i:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit number b:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter v = 0 or 1:");
        int v = int.Parse(Console.ReadLine());
        
        //The ~ operator performs a bitwise complement operation on its operand, which has the effect of reversing each bit. 
        //Bitwise complement operators are predefined for int, uint, long, and ulong.
        
        int mask = ~(1 << p);
        int bitNew = v << p;
        n = (n & mask) | bitNew;
        Console.WriteLine(n);
    }
}
