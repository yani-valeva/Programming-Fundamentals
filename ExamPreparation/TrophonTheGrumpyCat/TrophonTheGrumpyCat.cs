using System;
using System.Linq;

public class TrophonTheGrumpyCat
{
    public static void Main()
    {
        long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long entryPoint = long.Parse(Console.ReadLine());
        string itemType = Console.ReadLine();
        string priceRatingsType = Console.ReadLine();

        long entryNumber = numbers[entryPoint];
        long leftSum = 0;
        long rightSum = 0;

        if (itemType == "cheap" && priceRatingsType == "positive")
        {
            for (long i = 0; i < entryPoint; i++)
            {
                if (numbers[i] < entryNumber && numbers[i] >= 0)
                {
                    leftSum += numbers[i];
                }
            }

            for (long i = entryPoint + 1; i < numbers.Length; i++)
            {
                if (numbers[i] < entryNumber && numbers[i] >= 0)
                {
                    rightSum += numbers[i];
                }
            }
        }
        else if (itemType == "cheap" && priceRatingsType == "negative")
        {
            for (long i = 0; i < entryPoint; i++)
            {
                if (numbers[i] < entryNumber && numbers[i] < 0)
                {
                    leftSum += numbers[i];
                }
            }

            for (long i = entryPoint + 1; i < numbers.Length; i++)
            {
                if (numbers[i] < entryNumber && numbers[i] < 0)
                {
                    rightSum += numbers[i];
                }
            }
        }
        else if (itemType == "cheap" && priceRatingsType == "all")
        {
            for (long i = 0; i < entryPoint; i++)
            {
                if (numbers[i] < entryNumber)
                {
                    leftSum += numbers[i];
                }
            }

            for (long i = entryPoint + 1; i < numbers.Length; i++)
            {
                if (numbers[i] < entryNumber)
                {
                    rightSum += numbers[i];
                }
            }
        }
        else if (itemType == "expensive" && priceRatingsType == "positive")
        {
            for (long i = 0; i < entryPoint; i++)
            {
                if (numbers[i] >= entryNumber && numbers[i] >= 0)
                {
                    leftSum += numbers[i];
                }
            }

            for (long i = entryPoint + 1; i < numbers.Length; i++)
            {
                if (numbers[i] >= entryNumber && numbers[i] >= 0)
                {
                    rightSum += numbers[i];
                }
            }
        }
        else if (itemType == "expensive" && priceRatingsType == "negative")
        {
            for (long i = 0; i < entryPoint; i++)
            {
                if (numbers[i] >= entryNumber && numbers[i] < 0)
                {
                    leftSum += numbers[i];
                }
            }

            for (long i = entryPoint + 1; i < numbers.Length; i++)
            {
                if (numbers[i] >= entryNumber && numbers[i] < 0)
                {
                    rightSum += numbers[i];
                }
            }
        }
        else if (itemType == "expensive" && priceRatingsType == "all")
        {
            for (long i = 0; i < entryPoint; i++)
            {
                if (numbers[i] >= entryNumber)
                {
                    leftSum += numbers[i];
                }
            }

            for (long i = entryPoint + 1; i < numbers.Length; i++)
            {
                if (numbers[i] >= entryNumber)
                {
                    rightSum += numbers[i];
                }
            }
        }

        if (leftSum >= rightSum)
        {
            Console.WriteLine($"Left - {leftSum}");
        }
        else
        {
            Console.WriteLine($"Right - {rightSum}");
        }
    }
}
