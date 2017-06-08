using System;

public class DistanceOfTheStars
{
    public static void Main()
    {
        decimal distanceToNearestStar = 4.22m * 9460000000000m;
        decimal distanceToGalaxyCenter = 26000M * 9450000000000m;
        decimal milkyWayDiameter = 100000M * 9450000000000m;
        decimal distanceToTheUniverse = 46500000000M * 9450000000000M;

        Console.WriteLine(distanceToNearestStar.ToString("e2"));
        Console.WriteLine(distanceToGalaxyCenter.ToString("e2"));
        Console.WriteLine(milkyWayDiameter.ToString("e2"));
        Console.WriteLine(distanceToTheUniverse.ToString("e2"));
    }
}
