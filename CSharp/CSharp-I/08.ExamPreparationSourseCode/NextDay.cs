using System;

//We are given a date (day + month + year). Write a program to print the next day.
//Input
//The input data consists of 3 lines holding the integer numbers: day, month and year.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data should be printed on the console in the format day.month.year (no leading zeroes).
//Constraints

class NextDay
{
    static void Main()
    {
        //Console.WriteLine("Please enter a day:");
        int day = int.Parse(Console.ReadLine());

        //Console.WriteLine("Please enter a maunth:");
        int month = int.Parse(Console.ReadLine());

        //Console.WriteLine("Please enter an year:");
        int year = int.Parse(Console.ReadLine());
        DateTime date = new DateTime(year, month, day);
        DateTime nextDate = date.AddDays(1);
        
        Console.WriteLine(nextDate.Day + "." + nextDate.Month + "." + nextDate.Year);
    }
}

