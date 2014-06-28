using System;
//Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true

class Compares
{
    static void Main()
    {
        decimal a = 5.3m;
        decimal b = 6.01m;
        decimal c = 5.0000001m;
        decimal d = 5.00000003m;
        
        decimal result1 = Math.Abs(a - b);
        decimal result2 = Math.Abs(c - d);
        
        bool compare1 = (result1 < 0.000001m);
        bool compare2 = (result2 < 0.000001m);

        Console.WriteLine("Are the numbers eqally?\n{0} and {1} = {2}", a, b, compare1);
        Console.WriteLine("Are the numbers eqally?\n{0} and {1} = {2}", c, d, compare2);
    }
}
