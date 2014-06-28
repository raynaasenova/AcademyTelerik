using System;
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

class DeklareFiveVariables
{
    static void Main()
    {
        byte variable0 = 97; //0 to 255
        sbyte variable1 = -115; //-128 to 127
        short variable2 = -10000; //-32768 to 32767
        int variable3 = 52130; //-2147483648 to 2147483647
        uint variable4 = 4825932; //0 to 4294967295
        Console.WriteLine("byte: {0}\nsbyte {1}\nshort: {2}\nint: {3}\nuint: {4}", variable0, variable1, variable2, variable3, variable4);
    }
}

