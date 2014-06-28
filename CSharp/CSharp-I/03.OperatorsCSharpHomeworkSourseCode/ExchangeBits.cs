using System;
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
class ExchangeBits
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number n:");
        uint n = uint.Parse(Console.ReadLine());

        uint mask3b4b5b = (1 << 3) | (1 << 4) | (1 << 5);
        uint mask24b25b26b = (1 << 24) | (1 << 25) | (1 << 26);

        uint subBits3b4b5b = n & mask3b4b5b;
        uint subBits24b25b26b = n & mask24b25b26b;

        n = (~mask24b25b26b & n) | (subBits3b4b5b << 21);
        n = (~mask3b4b5b & n) | (subBits24b25b26b >> 21);

        Console.WriteLine(n);
    }
}

