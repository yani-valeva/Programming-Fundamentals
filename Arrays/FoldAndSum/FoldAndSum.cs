using System;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = numbers.Length / 4;
        int[] firstRow = new int[2 * k];

        for (int i = 0; i < k; i++)
        {
            firstRow[i] = numbers[k - 1 - i];
        }

        int position = numbers.Length - 1;

        for (int i = k; i < 2 * k; i++)
        {           
            firstRow[i] = numbers[position];
            position--;
        }
        
        int[] secondRow = numbers.Skip(k).Take(2 * k).ToArray();
        int[] sum = new int[2 * k];

        for (int i = 0; i < 2 * k; i++)
        {
            sum[i] = firstRow[i] + secondRow[i];
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}
