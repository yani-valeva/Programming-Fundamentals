using System;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int length = 1;
        int maxLength = 0;
        int position = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                length++;

                if (i == numbers.Length - 2 && maxLength < length)
                {
                    maxLength = length;
                    position = i + 2 - length;
                }            
            }
            else
            {
                if (maxLength < length)
                {
                    maxLength = length;
                    position = i + 1 - length;                  
                }

                length = 1;
            }
        }

        for (int i = position; i < position + maxLength; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
    }
}
