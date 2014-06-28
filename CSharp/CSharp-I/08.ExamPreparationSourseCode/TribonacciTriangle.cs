using System;

//You all know the Fibonacci sequence. Well, the Tribonacci sequence is almost the same, but it uses the last three numbers (instead of the last two) to calculate the next number in the sequence. So, we can define each element in the sequence as:
//T n = T n-1 + T n-2 + T n-3
//where T n is the current Tribonacci number (n is the index of the current Tribonacci number).
//The Tribonacci sequence can begin with any three integer numbers – positive or negative – and continue as described by the formula above.
//Now, a Tribonacci triangle is a triangle of numbers from the Tribonacci sequence. The first line of the triangle contains only the first number of the Tribonacci sequence. The second line contains the second and third numbers of the Tribonacci sequence, separated by a single whitespace (" "). The third line contains the next three numbers of the Tribonacci sequence (again, separated by whitespaces). The fourth line contains the next four numbers and so on. Basically, every line contains one more number than the previous.
//Your task is to write a program, which prints to the console a Tribonacci triangle by given the first three numbers of the Tribonacci sequence, and the number of lines in the triangle.

class TribonacciTriangle
{
    static void Main()
    {
        long oldest = long.Parse(Console.ReadLine()),
        middle = long.Parse(Console.ReadLine()),
        newest = long.Parse(Console.ReadLine());

        int rowsToGenerate = int.Parse(Console.ReadLine());

        Console.WriteLine(oldest);
        Console.WriteLine(middle + " " + newest);

        int currentRow = 3;
        int currentCol = 0;

        while (currentRow <= rowsToGenerate)
        {
            long currentNumber = oldest + middle + newest;

            oldest = middle;
            middle = newest;
            newest = currentNumber;

            currentCol++;

            if (currentCol < currentRow)
            {
                Console.Write(currentNumber + " ");
            }
            else
            {
                Console.WriteLine(currentNumber);
                currentCol = 0;
                currentRow++;
            }
        }
    }
}
