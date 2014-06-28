using System;
//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

class TheFirstIntegerIsGreater
{
    static void Main()
    {
        Console.WriteLine("Please, enter the first integer number:");
        string inputBiggerNum = Console.ReadLine();
        long biggerNum = long.Parse(inputBiggerNum);

        Console.WriteLine("Please, enter the second integer number:");
        string inputSmallerNum = Console.ReadLine();
        long smallerNum = long.Parse(inputSmallerNum);

        if (smallerNum == biggerNum)
        {
            Console.WriteLine("The first number {0} is equally with the second number {1}. ", biggerNum, smallerNum);
        }
        else             
            if (smallerNum > biggerNum)
                {
                     biggerNum = smallerNum;
                     Console.WriteLine("The greater number is {0}.", biggerNum);
                }
            else 
                {
                      Console.WriteLine("The greater number is {0}.", biggerNum);
                }
     }
}
