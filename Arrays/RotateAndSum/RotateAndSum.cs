using System;
using System.Linq;

public class RotateAndSum
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int numberOfRotations = int.Parse(Console.ReadLine());

        int[] sum = new int[numbers.Length];
        
        for (int i = 0; i < numberOfRotations; i++)
        {
            int number = numbers[numbers.Length - 1];

            for (int j = numbers.Length - 2; j >= 0; j--)
            {
                numbers[j + 1] = numbers[j];            
            }
            numbers[0] = number;

            for (int k = 0; k < numbers.Length; k++)
            {
                sum[k] += numbers[k];
            }
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}
