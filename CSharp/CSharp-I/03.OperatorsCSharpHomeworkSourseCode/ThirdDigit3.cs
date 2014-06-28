using System;

//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

class ThirdDigit3
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number:");
        int a = int.Parse(Console.ReadLine());
        a = (a / 100) % 10;
        short b = 7;
        //The conditional-OR operator (||) performs a logical-OR of its bool operands. If the first operand evaluates to true, the second operand isn't evaluated. If the first operand evaluates to false, the second operator determines whether the OR expression as a whole evaluates to true or false.
        bool c = (b == a || b == -a);
        if (c == true)
        {
            Console.WriteLine("The third digit (right-to-left) is 7.");
        }
        else
        {
            Console.WriteLine("The third digit (right-to-left) isn't 7.");
        }
    }
}

