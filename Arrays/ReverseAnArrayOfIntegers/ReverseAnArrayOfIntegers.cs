using System;

public class ReverseAnArrayOfIntegers
{
    public static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = numbersCount - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
    }
}
