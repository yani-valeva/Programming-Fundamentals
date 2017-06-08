using System;

public class TravelingAtLightSpeed
{
    public static void Main()
    {
        decimal lightYearsCount = decimal.Parse(Console.ReadLine());
        decimal lightYearKm = 9450000000000m;
        decimal lightSpeed = 300000m;

        decimal seconds = (lightYearKm / lightSpeed) * lightYearsCount;
        TimeSpan time = TimeSpan.FromSeconds((double)seconds);
     
        Console.WriteLine($"{time.Days / 7} weeks\n{time.Days % 7} days\n{time.Hours} hours\n{time.Minutes} minutes\n{time.Seconds} seconds");
    }
}
