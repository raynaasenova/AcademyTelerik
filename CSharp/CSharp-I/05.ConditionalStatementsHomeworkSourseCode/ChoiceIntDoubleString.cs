using System;

//Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

class ChoiceIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please, enter your choice: \n1 for Integer \n2 for Double \n3 for String");
        byte input = byte.Parse(Console.ReadLine());
        if (input == 1)
        {
            Console.WriteLine("Please, enter an Integer number: ");     
        }
        else if (input == 2)
        {
            Console.WriteLine("Please, enter a double number: ");
        }
        else if (input == 3)
        {
            Console.WriteLine("Please, enter your string: ");   
        }       
        
        switch (input)
        {
            case 1: int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer + 1);
                break;
            case 2: double floating = double.Parse(Console.ReadLine());
                Console.WriteLine(floating + 1);
                break;
            case 3: string inputStr = Console.ReadLine();
                Console.WriteLine(inputStr + "*");
                break;
            default: Console.WriteLine("Please, enter: 1 for Integer, 2 for double or 3 string variable: ");
                break;
        }
    }
}

