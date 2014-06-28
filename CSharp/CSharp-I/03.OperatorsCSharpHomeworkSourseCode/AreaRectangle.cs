using System;
//Write an expression that calculates rectangle’s area by given width and height.
class AreaRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter a width:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a height:");
        double b = double.Parse(Console.ReadLine());
        double area = ((a * 2) + (b * 2));
        Console.WriteLine("The area on the rectangle is: {0}", area);
    }
}

