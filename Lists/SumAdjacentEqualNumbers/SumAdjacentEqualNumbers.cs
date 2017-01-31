using System;
using System.Collections.Generic;
using System.Linq;

public class SumAdjacentEqualNumbers
{
    public static void Main()
    {
        List<decimal> numbers = Console.ReadLine()
                                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(decimal.Parse)
                                   .ToList();

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                numbers[i] = numbers[i] + numbers[i + 1];
                numbers.Remove(numbers[i + 1]);
                i = -1;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
