using System;

public class HornetWings
{
    public static void Main()
    {
        long wingFlaps = long.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        long endurance = long.Parse(Console.ReadLine());

        double resultDistance = (wingFlaps / 1000.0) * distance;
        double flapsPerSeconds = wingFlaps / 100.0;
        double timeInSeconds = ((wingFlaps / endurance) * 5) + flapsPerSeconds;

        Console.WriteLine($"{resultDistance:f2} m.");
        Console.WriteLine($"{timeInSeconds} s.");
    }
}

