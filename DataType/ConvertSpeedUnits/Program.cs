using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeInSeconds = (hours * 3600f) + (minutes * 60f) + seconds;
            float timeInHours = (seconds / 3600f) + (minutes / 60f) + hours;

            float speedInMetersPerSecond = distanceInMeters / timeInSeconds;
            float speedInKilometersPerHour = (distanceInMeters / 1000f) / timeInHours;
            float speedInMilesPerHour = (distanceInMeters / 1609f) / timeInHours;

            Console.WriteLine($"{speedInMetersPerSecond}\n{speedInKilometersPerHour}\n{speedInMilesPerHour}");

        }
    }
}
