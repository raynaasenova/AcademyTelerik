using System;

//Write an expression that checks if given integer is odd or even.

class OddEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int a = int.Parse(Console.ReadLine());
        //The % operator computes the remainder after dividing its first operand by its second. 
       
        if (a % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd."); 
        }
    }
}


