using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveNegativesAndReverse
{
    public static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> numbers = new List<int>();

        for (int i = input.Count - 1; i >= 0; i--)
        {
            if (input[i] >= 0)
            {
                numbers.Add(input[i]);
            }
        }

        if (numbers.Count > 0)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}