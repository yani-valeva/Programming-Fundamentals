using System;

public class CharityMarathon
{
    public static void Main()
    {
        long days = long.Parse(Console.ReadLine());
        long numberOfRunners = long.Parse(Console.ReadLine());
        long averageNumberOfLaps = long.Parse(Console.ReadLine());
        long trackLength = long.Parse(Console.ReadLine());
        long trackCapacity = long.Parse(Console.ReadLine());
        decimal moneyPerKm = decimal.Parse(Console.ReadLine());

        long totalCapacityOfRunners = days * trackCapacity;
        long totalNumberOfRunners = 0;

        if (numberOfRunners >= totalCapacityOfRunners)
        {
            totalNumberOfRunners = totalCapacityOfRunners;
        }
        else
        {
            totalNumberOfRunners = numberOfRunners;
        }

        long totalKm = (totalNumberOfRunners * averageNumberOfLaps * trackLength) / 1000;
        decimal totalRaisedMoney = totalKm * moneyPerKm;

        Console.WriteLine($"Money raised: {totalRaisedMoney:f2}");
    }
}
