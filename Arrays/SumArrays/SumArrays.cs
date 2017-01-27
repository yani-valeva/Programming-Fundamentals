using System;
using System.Linq;

public class SumArrays
{
    public static void Main()
    {
        int[] firstRowOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondRowOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int maxLength = Math.Max(firstRowOfNumbers.Length, secondRowOfNumbers.Length);

        for (int i = 0; i < maxLength; i++)
        {
            int sum = 0;

            if (firstRowOfNumbers.Length == secondRowOfNumbers.Length)
            {
                Console.Write(firstRowOfNumbers[i] + secondRowOfNumbers[i] + " ");
            }
            else if (firstRowOfNumbers.Length > secondRowOfNumbers.Length)
            {
                if (i <= secondRowOfNumbers.Length - 1)
                {
                    Console.Write(firstRowOfNumbers[i] + secondRowOfNumbers[i] + " ");
                }
                else
                {
                    int position = i % secondRowOfNumbers.Length;
                    Console.Write(firstRowOfNumbers[i] + secondRowOfNumbers[position] + " ");
                }
            }
            else
            {
                if (i <= firstRowOfNumbers.Length - 1)
                {
                    Console.Write(firstRowOfNumbers[i] + secondRowOfNumbers[i] + " ");
                }
                else
                {
                    int position = i % firstRowOfNumbers.Length;
                    Console.Write(firstRowOfNumbers[position] + secondRowOfNumbers[i] + " ");
                }
            }
        }

        Console.WriteLine();
    }
}
