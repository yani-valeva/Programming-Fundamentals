using System;

class CenterPoint
{
    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double firstPointDistance = GetDistanceBetweenTwoPoints(x1, y1, 0, 0);
        double secondPointDistance = GetDistanceBetweenTwoPoints(x2, y2, 0, 0);

        PrintClosestPointToTheCenter(firstPointDistance, secondPointDistance, x1, y1, x2, y2);

    }

    public static void PrintClosestPointToTheCenter(double firstPointDistance, double secondPointDistance, double x1, double y1, double x2, double y2)
    {
        if (firstPointDistance <= secondPointDistance)
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})");
        }
    }

    public static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }
}