using System;

class PriceChangeAlert
{
    public static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());

            double difference = GetPercentageDifference(lastPrice, currentPrice);
            bool isSignificantDifference = HasSignificantDifference(difference, significanceThreshold);
            string message = GetMessage(currentPrice, lastPrice, difference, isSignificantDifference);

            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    public static string GetMessage(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
    {
        string result = "";
        if (difference == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }            
        return result;
    }

    public static bool HasSignificantDifference(double difference, double significanceThreshold)
    {
        if (Math.Abs(significanceThreshold) <= Math.Abs(difference))
        {
            return true;
        }
        return false;
    }

    public static double GetPercentageDifference(double lastPrice, double currentPrice)
    {
        double result = (currentPrice - lastPrice) / lastPrice;
        return result;
    }
}
