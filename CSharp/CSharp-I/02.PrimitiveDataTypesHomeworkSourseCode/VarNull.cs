using System;
//Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

class VarNull
{
static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("Integer with null value: {0}", a);
        Console.WriteLine("Double with null value: {0}", b);
        a = 5;
        b = 7.7;
        Console.WriteLine(a);
        Console.WriteLine(b);        
    }
}