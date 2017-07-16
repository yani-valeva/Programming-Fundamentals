using System;

public class PokeMons
{
    public static void Main()
    {
        long power = long.Parse(Console.ReadLine());
        long distance = long.Parse(Console.ReadLine());
        int count = 0;
        long currentPower = power;
        long currentDistance = distance;

        while (power > distance)
        {
            power -= distance;
            count++;
            double percent = ((double)power / currentPower) * 100.0;
            int result = (int)(100 - percent);

            if (result >= 10)
            {
                distance = currentDistance;
                int pow = result / 10;
                distance = (int)(distance * Math.Pow(2, pow));
            }
        }

        Console.WriteLine(power);
        Console.WriteLine(count);
    }
}
