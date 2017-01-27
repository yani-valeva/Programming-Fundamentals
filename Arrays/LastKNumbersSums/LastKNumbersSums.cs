using System;

public class LastKNumbersSums
{
    public static void Main()
    {
        long numbersCount = long.Parse(Console.ReadLine());
        long countOfSumNumbers = long.Parse(Console.ReadLine());
        long[] numbers = new long[numbersCount];
        numbers[0] = 1;

        for (long i = 1; i < numbersCount; i++)
        {
            long startPosition = i - countOfSumNumbers;

            if(startPosition < 0)
            {
                startPosition = 0;
            }

            for (long j = i - 1; j >= startPosition; j--)
            {
                numbers[i] += numbers[j];
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
