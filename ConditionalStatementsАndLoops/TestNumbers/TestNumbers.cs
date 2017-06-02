using System;

public class TestNumbers
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int boundary = int.Parse(Console.ReadLine());

        int result = 0;
        int count = 0;

        for (int firstDigit = firstNumber; firstDigit >= 1; firstDigit--)
        {
            for (int secondDigit = 1; secondDigit <= secondNumber; secondDigit++)
            {
                result += firstDigit * secondDigit * 3;
                count++;

                if (result >= boundary)
                {
                    Console.WriteLine($"{count} combinations");
                    Console.WriteLine($"Sum: {result} >= {boundary}");
                    return;
                }
            }
        }

        Console.WriteLine($"{count} combinations");
        Console.WriteLine($"Sum: {result}");
    }
}
