using System;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = numbers.Length / 4;
        int[] leftPartOfFirstRow = new int[k];
        int[] rightPartOfFirstRow = new int[k];
        int[] firstRow = new int[2 * k];
        int[] secondRow = new int[2 * k];

        leftPartOfFirstRow = numbers.Take(k).Reverse().ToArray();
        rightPartOfFirstRow = numbers.Reverse().Take(k).ToArray();
        firstRow = leftPartOfFirstRow.Concat(rightPartOfFirstRow).ToArray();
        secondRow = numbers.Skip(k).Take(2 * k).ToArray();

        int[] sum = new int[2 * k];

        for (int i = 0; i < sum.Length; i++)
        {
            sum[i] = firstRow[i] + secondRow[i];
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}
