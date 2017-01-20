using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long amountOfTakenPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadedTime = long.Parse(Console.ReadLine());

            long filtredPictures = (long)Math.Ceiling(filterFactor * amountOfTakenPictures / 100.0);
            long timeInSecondsForAllPictures = amountOfTakenPictures * filterTime;
            long timeInSecondsForFiltredPictures = filtredPictures * uploadedTime;
            long totalTimeInSeconds = timeInSecondsForAllPictures + timeInSecondsForFiltredPictures;
            TimeSpan time = TimeSpan.FromSeconds(totalTimeInSeconds);

            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", time.Days, time.Hours, time.Minutes, time.Seconds);
            
        }
    }
}
