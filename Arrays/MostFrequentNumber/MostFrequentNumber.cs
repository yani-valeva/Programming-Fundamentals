using System;
using System.Linq;

public class MostFrequentNumber
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int mostFrequentNumber = numbers[0];
        int count = 1;
        int maxCount = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                }
            }

            if (maxCount < count)
            {
                maxCount = count;
                mostFrequentNumber = numbers[i];
            }

            count = 1;
        }

        Console.WriteLine(mostFrequentNumber);
    }
}