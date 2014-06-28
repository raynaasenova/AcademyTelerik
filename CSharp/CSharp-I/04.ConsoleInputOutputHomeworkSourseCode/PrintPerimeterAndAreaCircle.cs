using System;

//Write a program that reads the radius r of a circle and printsits perimeter  and area.

class PrintPerimeterAndAreaCircle
{
    static void Main()
    {
        Console.WriteLine("Enter the perimeter r:");
        string inputR = Console.ReadLine();
        double r = double.Parse(inputR);

        double per = 2 * Math.PI * r;
        double area = Math.PI * r * r;
        Console.WriteLine("The perimeter of the circle is {0:F2}.\r\nThe area or the circle is {1:F2}.", per, area);
    }
}

