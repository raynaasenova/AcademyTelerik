using System;

//Sort 3 real values in descending order using nested if statements.

class ThreeRealValuesInDescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Please, enter the first integer number:");
        int a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please, enter the second integer number:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Please, enter the third integer number:");
        int c = int.Parse(Console.ReadLine());

        if (a == b && a == c)
        {
            Console.WriteLine("The numbers is eqally");
        }
        if (a > b && a > c)
        {
            if (b > c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
            }
        }
        else if (b > a && b > c)
        {
            if (a > c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
        }
        else if (c > a && c > b)	        
        {
           if (a > b)
           {
               Console.WriteLine(c);
               Console.WriteLine(a);
               Console.WriteLine(b);
           }
           else
           {
               Console.WriteLine(c);
               Console.WriteLine(b);
               Console.WriteLine(a);
           }	        
        }    
    }
}

