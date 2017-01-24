using System;
using System.Numerics;

class Factorial
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        PrintFactorial(number);
    }

    public static void PrintFactorial(int number)
    {
        BigInteger factorial = 1;

        for (int i = number; i >= 1; i--)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}
