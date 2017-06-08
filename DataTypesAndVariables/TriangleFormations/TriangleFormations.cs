using System;

public class TriangleFormations
{
    public static void Main()
    {
        int firstSide = int.Parse(Console.ReadLine());
        int secondSide = int.Parse(Console.ReadLine());
        int thirdSide = int.Parse(Console.ReadLine());

        bool isValid = firstSide + secondSide > thirdSide &&
            secondSide + thirdSide > firstSide &&
            thirdSide + firstSide > secondSide;

        if (!isValid)
        {
            Console.WriteLine("Invalid Triangle.");
            return;
        }

        Console.WriteLine("Triangle is valid.");
        PrintResult(firstSide, secondSide, thirdSide);
    }

    private static void PrintResult(int firstSide, int secondSide, int thirdSide)
    {
        if (Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2) == Math.Pow(thirdSide, 2))
        {
            Console.WriteLine("Triangle has a right angle between sides a and b");
            return;
        }
        else if (Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2))
        {
            Console.WriteLine("Triangle has a right angle between sides b and c");
            return;
        }
        else if (Math.Pow(thirdSide, 2) + Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2))
        {
            Console.WriteLine("Triangle has a right angle between sides a and c");
            return;
        }

        Console.WriteLine("Triangle has no right angles");      
    }
}
