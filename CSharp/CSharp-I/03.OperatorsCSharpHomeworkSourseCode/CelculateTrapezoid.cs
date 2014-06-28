using System;
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

    class CelculateTrapezoid
    {
        static void Main()
        {
            Console.WriteLine("To calculate trapezoid's area, enter a = ?, b = ?, h = ?");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (a * b) * h / 2;
            Console.WriteLine(area);
        }
    }

