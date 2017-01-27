using System;
using System.Linq;

public class CondenseArrayToNumber
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int length = numbers.Length;

        while (length > 1)
        {
            int[] condensed = new int[length - 1];

            for (int i = 0; i < length - 1; i++)
            {
                condensed[i] = numbers[i] + numbers[i + 1];
            }

            length--;            
            numbers = condensed;
        }

        Console.WriteLine(numbers[0]);
    }
}
