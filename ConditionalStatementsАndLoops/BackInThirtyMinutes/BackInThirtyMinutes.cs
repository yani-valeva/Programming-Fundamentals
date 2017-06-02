using System;

public class BackInThirtyMinutes
{
    public static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 30 + (hours * 60);

        hours = minutes / 60;
        minutes = minutes % 60;

        if (hours > 23)
        {
            hours -= 24;
        }

        Console.WriteLine($"{hours}:{minutes:00}");
    }
}
