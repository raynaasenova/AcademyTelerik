using System;

//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

class CheckThePoint
{
    static void Main()
    {
        Console.WriteLine("Enter the point X to check if given point (x,  y) is within a circle K(O, 5).");
        double x = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the point Y to check if given point (x,  y) is within a circle K(O, 5).");
        double y = double.Parse(Console.ReadLine());
        
        double radius = 5;

        if ((x * x + y * y) <= radius * radius)
        {
            Console.WriteLine("The point with coordinates ({0}, {1}) is in circle K(0,5)", x, y);
        }
        else
        {
            Console.WriteLine("The point with coordinates ({0}, {1}) isn't in circle K(0,5)", x, y);
        }
    }
}

