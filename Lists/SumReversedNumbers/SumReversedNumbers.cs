using System;
using System.Collections.Generic;
using System.Linq;

public class SumReversedNumbers
{
    public static void Main()
    {
        List<string> numbers = Console.ReadLine().Split(' ').ToList();

        int sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            string numberAsString = numbers[i];
            string reversedNumber = string.Empty;

            for (int j = numberAsString.Length - 1; j >= 0; j--)
            {
                reversedNumber += numberAsString[j];
            }

            sum += int.Parse(reversedNumber);
        }

        Console.WriteLine(sum);
    }
}
