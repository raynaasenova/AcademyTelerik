using System;

//Write a program that finds the greatest of given 5 variables.

class TheGreatestOfFive
{
    static void Main()
    {
        //double inputNumber;
        double greatestNumber = double.MinValue;
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter the {0} number: ", i + 1);
            double inputNumber = double.Parse(Console.ReadLine());
            
            if (inputNumber > greatestNumber)
            {
                greatestNumber = inputNumber;   
            }
       }
        Console.WriteLine("The greatest number is {0}.", greatestNumber);           
   }
}

