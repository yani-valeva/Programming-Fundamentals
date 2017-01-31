using System;
using System.Collections.Generic;
using System.Linq;

public class AppendLists
{
    public static void Main()
    {
        List<string> input = Console.ReadLine().Split('|').ToList();
        List<int> result = new List<int>();

        for (int i = input.Count - 1; i >= 0; i--)
        {
            List<int> numbers = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            result.AddRange(numbers);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
