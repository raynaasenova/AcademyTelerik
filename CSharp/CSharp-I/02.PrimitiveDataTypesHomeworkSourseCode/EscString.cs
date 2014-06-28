using System;
//Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//    Do the above in two different ways: with and without using quoted strings.

class EscString
{
    static void Main()
    {
        string escString1 = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(escString1);
        string escString2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(escString2);
    }
}

