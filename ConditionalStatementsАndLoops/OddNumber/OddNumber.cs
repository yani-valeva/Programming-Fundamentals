﻿using System;

public class OddNumber
{
    public static void Main()
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));

        while (true)
        {
            if (number % 2 != 0)
            {
                break;
            }

            Console.WriteLine("Please write an odd number.");
            number = Math.Abs(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine($"The number is: {number}");
    }
}
