using System;
//Write an expression that checks for given point (x, y) if it is within 
//the circle K( (1,1), 3) and out of 
//the rectangle R(top=1, left=-1, width=6, height=2).
class CircleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter the point X and Y:");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int radius = 3;
        //Circle co-ordinates: (1, 1) and radious = 3
        //Rectangle co-ordinates: (-1, 1) and (5, 3)
        
        bool circle = (x * x + y * y) < radius * radius;
        bool rectangle = x > -1 && x < 5 && y > 1 && y < 3;
        //The logical negation operator (!) is a unary operator that negates its operand. 
        //It is defined for bool and returns true if and only if its operand is false.
        if (circle && !rectangle)
        {
            Console.WriteLine("Point is within the circle and in rectangle.");
        }
        else
        {
            Console.WriteLine("Point is out of the circle or out of rectangle.");
        }
    }
}

