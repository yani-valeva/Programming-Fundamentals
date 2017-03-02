using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniWaterSupplies
{
    public static void Main()
    {
        decimal water = decimal.Parse(Console.ReadLine());
        decimal[] bottles = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        decimal bottleCapacity = decimal.Parse(Console.ReadLine());
        decimal neededWater = 0m;
        int lastFilledBottle = -1;

        if (water % 2 == 0)
        {
            for (int i = 0; i < bottles.Length; i++)
            {
                if (bottleCapacity >= bottles[i])
                {
                    neededWater += bottleCapacity - bottles[i];

                    if (water >= neededWater)
                    {
                        lastFilledBottle = i;
                    }
                }
            }
        }
        else
        {
            for (int i = bottles.Length - 1; i >= 0; i--)
            {
                if (bottleCapacity >= bottles[i])
                {
                    neededWater += bottleCapacity - bottles[i];

                    if (water >= neededWater)
                    {
                        lastFilledBottle = i;
                    }
                }
            }
        }

        if (water % 2 == 0 && lastFilledBottle == bottles.Length - 1)
        {
            Console.WriteLine("Enough water!");
            Console.WriteLine($"Water left: {water - neededWater}l.");
        }
        else if (water % 2 == 0 && lastFilledBottle < bottles.Length - 1)
        {
            List<int> emptyBottles = new List<int>();

            for (int i = lastFilledBottle + 1; i < bottles.Length; i++)
            {
                emptyBottles.Add(i);
            }
            Console.WriteLine($"We need more water!");
            Console.WriteLine($"Bottles left: {(bottles.Length - 1) - lastFilledBottle}");
            Console.WriteLine($"With indexes: {string.Join(", ", emptyBottles)}");
            Console.WriteLine($"We need {neededWater - water} more liters!");
        }
        else if (water % 2 != 0 && lastFilledBottle == 0)
        {
            Console.WriteLine("Enough water!");
            Console.WriteLine($"Water left: {water - neededWater}l.");
        }
        else if (water % 2 != 0 && (lastFilledBottle > 0 || lastFilledBottle == -1))
        {
            if (lastFilledBottle == -1)
            {
                lastFilledBottle = bottles.Length;
            }

            List<int> emptyBottles = new List<int>();

            for (int i = lastFilledBottle - 1; i >= 0; i--)
            {
                emptyBottles.Add(i);
            }
            Console.WriteLine($"We need more water!");
            Console.WriteLine($"Bottles left: {lastFilledBottle}");
            Console.WriteLine($"With indexes: {string.Join(", ", emptyBottles)}");
            Console.WriteLine($"We need {neededWater - water} more liters!");
        }
    }
}