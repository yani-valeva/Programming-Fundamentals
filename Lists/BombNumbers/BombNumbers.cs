using System;
using System.Collections.Generic;
using System.Linq;

public class BombNumbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> bombAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int bomb = bombAndPower[0];
        int power = bombAndPower[1];

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bomb)
            {
                int startIndex = i - power;
                int endIndex = i + power;
                
                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex > numbers.Count - 1)
                {
                    endIndex = numbers.Count - 1;
                }

                int count = endIndex + 1 - startIndex;
                numbers.RemoveRange(startIndex, count);
                i = -1;
            }
        }

        int sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine(sum);
    }
}
