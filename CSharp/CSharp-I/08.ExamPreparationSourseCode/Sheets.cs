using System;

class Sheets
{
     static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 10; i >= 0; i--)
        {
            if ((N & 1) == 0) // Check if last bit is zero
            {
                Console.WriteLine("A{0}", i);
            }
            N >>= 1;
        }
    }
}
