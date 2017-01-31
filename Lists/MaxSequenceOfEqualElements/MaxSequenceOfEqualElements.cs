using System;
using System.Collections.Generic;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int count = 1;
        int maxCount = 0;
        int start = 0;

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                count++;

                if (i == numbers.Count - 2 && maxCount < count)
                {
                    maxCount = count;
                    start = i + 2 - maxCount;
                }              
            }
            else
            {
                if (maxCount < count)
                {
                    maxCount = count;
                    start = i + 1 - maxCount;                   
                }

                count = 1;
            }
        }

        numbers = numbers.Skip(start).Take(maxCount).ToList();

        Console.WriteLine(string.Join(" ", numbers));
    }
}
