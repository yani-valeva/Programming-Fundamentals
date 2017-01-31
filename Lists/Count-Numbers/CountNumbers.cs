using System;
using System.Collections.Generic;
using System.Linq;

public class CountNumbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Dictionary<int, int> countNumbers = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (!countNumbers.ContainsKey(numbers[i]))
            {
                countNumbers.Add(numbers[i], 1);
            }
            else
            {
                countNumbers[numbers[i]] += 1;
            }
        }
        
        foreach (var key in countNumbers.OrderBy(n => n.Key))
        {
            Console.WriteLine($"{key.Key} -> {key.Value}");
        }
    }
}
