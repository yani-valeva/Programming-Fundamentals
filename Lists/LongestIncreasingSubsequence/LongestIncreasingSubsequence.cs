using System;
using System.Collections.Generic;
using System.Linq;

public class LongestIncreasingSubsequence
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var longestSequence = FindLongestIncreasingSubsequence(numbers);

        Console.WriteLine(string.Join(" ", longestSequence));
    }

    public static List<int> FindLongestIncreasingSubsequence(List<int> numbers)
    {
        int[] length = new int[numbers.Count];
        int[] previous = new int[numbers.Count];
        int maxLength = 0;
        int lastIndex = -1;

        for (int i = 0; i < numbers.Count; i++)
        {
            length[i] = 1;
            previous[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (numbers[j] < numbers[i] && length[j] >= length[i])
                {
                    length[i] = 1 + length[j];
                    previous[i] = j;
                }
            }

            if (length[i] > maxLength)
            {
                maxLength = length[i];
                lastIndex = i;
            }
        }

        List<int> longestSequenceOfIncreasingNumbers = new List<int>();
        for (int i = 0; i < maxLength; i++)
        {
            longestSequenceOfIncreasingNumbers.Add(numbers[lastIndex]);
            lastIndex = previous[lastIndex];
        }

        longestSequenceOfIncreasingNumbers.Reverse();
        return longestSequenceOfIncreasingNumbers.ToList();
    }
}

