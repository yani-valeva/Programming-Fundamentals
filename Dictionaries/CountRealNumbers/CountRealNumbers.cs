using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers
{
    public static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        SortedDictionary<double, int> numbersAndCounts = new SortedDictionary<double, int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (!numbersAndCounts.ContainsKey(numbers[i]))
            {
                numbersAndCounts.Add(numbers[i], 0);
            }

            numbersAndCounts[numbers[i]] += 1;
        }

        foreach (var key in numbersAndCounts)
        {
            Console.WriteLine($"{key.Key} -> {key.Value}");
        }
    }
}
