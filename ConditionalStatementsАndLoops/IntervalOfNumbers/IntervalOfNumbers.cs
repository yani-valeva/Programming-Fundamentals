using System;

public class IntervalOfNumbers
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int min = Math.Min(firstNumber, secondNumber);
        int max = Math.Max(firstNumber, secondNumber);

        for (int i = min; i <= max; i++)
        {
            Console.WriteLine(i);
        }
    }
}
