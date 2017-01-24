﻿using System;

class SignOfIntegerNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        PrintSign(number);
    }

    public static void PrintSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else
        {
            Console.WriteLine($"The number 0 is zero.");
        }
    }
}
