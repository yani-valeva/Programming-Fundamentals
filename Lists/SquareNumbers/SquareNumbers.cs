﻿using System;
using System.Collections.Generic;
using System.Linq;

public class SquareNumbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> squareNumbers = new List<int>();

        foreach (var number in numbers)
        {
            double result = Math.Sqrt(number);

            if (result == (int)result)
            {
                squareNumbers.Add(number);
            }
        }

        squareNumbers.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine(string.Join(" ", squareNumbers));
    }
}
