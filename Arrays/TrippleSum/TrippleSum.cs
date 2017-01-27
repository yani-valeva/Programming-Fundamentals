using System;
using System.Linq;

public class TrippleSum
{
    public static void Main()
    {
        long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        bool isFound = false;

        for (long i = 0; i < numbers.Length - 1; i++)
        {
            long firstNumber = numbers[i];

            for (long j = i + 1; j < numbers.Length; j++)
            {
                long secondNumber = numbers[j];

                for (long k = 0; k < numbers.Length; k++)
                {
                    if(firstNumber + secondNumber == numbers[k])
                    {
                        Console.WriteLine($"{firstNumber} + {secondNumber} == {numbers[k]}");
                        isFound = true;
                        break;
                    }
                }
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}
