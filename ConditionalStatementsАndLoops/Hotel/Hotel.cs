using System;

public class Hotel
{
    public static void Main()
    {
        string month = Console.ReadLine();
        int nightsCount = int.Parse(Console.ReadLine());
        decimal totalStudioPrice = 0m;
        decimal totalDoublePrice = 0m;
        decimal totalSuitePrice = 0m;

        switch (month)
        {
            case "May":
            case "October":
                totalStudioPrice = nightsCount * 50m;
                totalDoublePrice = nightsCount * 65m;
                totalSuitePrice = nightsCount * 75m;
                if (nightsCount > 7 && month == "October")
                {
                    decimal currentStudioPrice = 50m * 0.95m;
                    nightsCount--;
                    totalStudioPrice = nightsCount * currentStudioPrice;
                }
                else if (nightsCount > 7)
                {
                    totalStudioPrice = nightsCount * 50m * 0.95m;
                }
                break;
            case "June":
            case "September":
                totalDoublePrice = nightsCount * 72m;
                totalSuitePrice = nightsCount * 82m;

                if (nightsCount > 14)
                {
                    totalDoublePrice = nightsCount * 72m * 0.90m;
                }
                if (nightsCount > 7 && month == "September")
                {
                    nightsCount--;
                }

                totalStudioPrice = nightsCount * 60m;
                break;
            case "July":
            case "August":
            case "December":
                totalStudioPrice = nightsCount * 68m;
                totalDoublePrice = nightsCount * 77m;
                totalSuitePrice = nightsCount * 89m;

                if (nightsCount > 14)
                {
                    totalSuitePrice = nightsCount * 89m * 0.85m;
                }
                break;
        }

        Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
        Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");
    }
}
