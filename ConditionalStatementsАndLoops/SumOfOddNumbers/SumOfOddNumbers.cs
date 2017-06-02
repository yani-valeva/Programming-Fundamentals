using System;

public class SumOfOddNumbers
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            int currentNumber = (i * 2) - 1;
            sum += currentNumber;
            Console.WriteLine(currentNumber);
        }

        Console.WriteLine($"Sum: {sum}");
    }
}
