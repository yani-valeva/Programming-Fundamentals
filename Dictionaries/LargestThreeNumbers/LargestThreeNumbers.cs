using System;
using System.Collections.Generic;
using System.Linq;

public class LargestThreeNumbers
{
    public static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        numbers = numbers.OrderByDescending(n => n).Take(3).ToList();

        Console.WriteLine(string.Join(" ", numbers));
    }
}
