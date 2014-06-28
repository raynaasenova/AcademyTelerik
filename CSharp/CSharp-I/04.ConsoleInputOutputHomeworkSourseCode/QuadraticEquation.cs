using System;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

class QuadraticEquation
{
    static void Main()
    {
        //a != 0
        Console.Write("Enter a number different from 0, a: ");
        string input = Console.ReadLine();
        double a = double.Parse(input);
        
        Console.Write("Enter b: ");
        input = Console.ReadLine();
        double b = double.Parse(input);

        Console.Write("Enter c: ");
        input = Console.ReadLine();
        double c = double.Parse(input);

        // Calculate discriminant
        double discr = b * b - 4 * a * c;
        
       
        if (discr > 0)
        {            
            double x1 = ((- b + Math.Sqrt(discr)) / (2.0 * a));
            double x2  = ((- b - Math.Sqrt(discr)) / (2.0 * a));
            Console.WriteLine("x1 = {0:F2}", x1);
            Console.WriteLine("x2 = {0:F2}", x2);
        }
        else if (discr == 0)
        {
            double x1 = -b / 2 * a;
            Console.WriteLine("x1 = x2 = {0:F2}", x1);
        }
        else
        {
            Console.WriteLine("D < 0. Not a poot.");
        }            
    }
}

