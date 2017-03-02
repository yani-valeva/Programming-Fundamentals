using System;

public class TheaThePhotographer
{
    public static void Main()
    {
        long takenPictures = long.Parse(Console.ReadLine());
        long filterTimePerPicture = long.Parse(Console.ReadLine());
        double filterFactor = double.Parse(Console.ReadLine()) / 100;
        long uploadedTimePerPicture = long.Parse(Console.ReadLine());
        long filteredPictures = (long)Math.Ceiling(filterFactor * takenPictures);
        long totalFilterTime = takenPictures * filterTimePerPicture;
        long totalUplodedTime = filteredPictures * uploadedTimePerPicture;
        long totalTime = totalFilterTime + totalUplodedTime;

        TimeSpan time = TimeSpan.FromSeconds(totalTime);
        string result = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}", time.Days, time.Hours, time.Minutes, time.Seconds);

        Console.WriteLine(result);
    }
}
