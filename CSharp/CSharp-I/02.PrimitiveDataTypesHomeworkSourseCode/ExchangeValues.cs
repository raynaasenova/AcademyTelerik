using System;
//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

class ExchangeValues
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;
        Console.WriteLine("Numbers are: a = {0} and b = {1}", a, b);
        byte c;
        c = a;
        a = b;
        b = c;
        Console.WriteLine("Exchanged numbers are: a = {0} and b = {1}", a, b);
    }
}

