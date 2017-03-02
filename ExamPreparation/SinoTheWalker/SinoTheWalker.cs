using System;
using System.Globalization;

public class SinoTheWalker
{
    public static void Main()
    {
        string input = Console.ReadLine();
        DateTime timeForLeavingSoftUni = DateTime.ParseExact(input, "HH:mm:ss", CultureInfo.InvariantCulture);
        double numberOfSteps = double.Parse(Console.ReadLine()) % 86400;
        double timeForStepInSeconds = double.Parse(Console.ReadLine()) % 86400;

        double neededTime = numberOfSteps * timeForStepInSeconds;
        string result = timeForLeavingSoftUni.AddSeconds(neededTime).ToString("HH:mm:ss");

        Console.WriteLine($"Time Arrival: {result}");
    }
}

