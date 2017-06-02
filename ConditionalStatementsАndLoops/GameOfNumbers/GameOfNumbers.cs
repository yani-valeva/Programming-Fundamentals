using System;

public class GameOfNumbers
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int currentFirst = 0;
        int currentSecond = 0;
        bool isFound = false;
        int count = 0;

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            for (int j = firstNumber; j <= secondNumber; j++)
            {
                if (i + j == magicNumber)
                {
                    currentFirst = i;
                    currentSecond = j;
                    isFound = true;
                }

                count++;
            }
        }

        if (isFound)
        {
            Console.WriteLine($"Number found! {currentFirst} + {currentSecond} = {magicNumber}");
        }
        else
        {
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}
