using System;

class MultiplyEvenByOdds
{
    public static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int number = Math.Abs(input);
        int multipleOfEvensAndOdds = GetMultipleOfEvensAndOdds(number);
        Console.WriteLine(multipleOfEvensAndOdds);
    }

    public static int GetMultipleOfEvensAndOdds(int number)
    {
        int evenSum = GetSumOfEvenDigits(number);
        int oddSum = GetSumOfOddDogits(number);
        return evenSum * oddSum;
    }

    public static int GetSumOfOddDogits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 1)
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }

    public static int GetSumOfEvenDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }
}
