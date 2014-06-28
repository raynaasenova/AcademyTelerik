using System;
//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

class ObjectString
{
    static void Main()
    {
        string w1 = "Hello";
        string w2 = "World";
        object conc = w1 + " " + w2;
        string sent = (string)conc;
        Console.WriteLine(sent);
    }
}

