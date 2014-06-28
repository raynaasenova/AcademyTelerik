using System;

class TheSequence
{
    static void Main()
    {
        for (int seq = 0; seq < 10; seq++)
        {
            if (seq % 2 == 0)
            {
                Console.Write("{0} ", seq + 2);
            }
            else
            {
                Console.Write("{0} ", -(seq + 2));
            }
        }
                Console.WriteLine();
    }
}