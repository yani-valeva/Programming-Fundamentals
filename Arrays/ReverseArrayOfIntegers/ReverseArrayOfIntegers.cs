using System;

public class ReverseArrayOfIntegers
{
    public static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int[] reversedNumbers = new int[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {
            reversedNumbers[i] = numbers[numbers.Length - 1 - i];
        }

        Console.WriteLine(string.Join(" ", reversedNumbers));
    }
}
