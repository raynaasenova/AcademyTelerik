using System;
//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

class BoolDivide5and7
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number:");
        int x = int.Parse(Console.ReadLine());
        //The conditional-AND operator (&&) performs a logical-AND of its bool operands.
        bool y = (x % 5 == 0 && x % 7 == 0); 
        Console.WriteLine("Is the number divisible to 5 and 7? \n{0}", y);          
          }
}

