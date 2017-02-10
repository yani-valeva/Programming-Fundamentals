using System;
using System.Linq;

public class DistanceBetweenPoint
{
    public static void Main()
    {
        Point firstPoint = ReadPoint();
        Point secondPoint = ReadPoint();

        double distance = CalculateDistance(firstPoint, secondPoint);

        Console.WriteLine($"{distance:f3}");
    }

    public static Point ReadPoint()
    {
        double[] pointInfo = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        Point point = new Point();
        point.X = pointInfo[0];
        point.Y = pointInfo[1];

        return point;
    }

    public static double CalculateDistance(Point firstPoint, Point secondPoint)
    {
        double firstSide = firstPoint.X - secondPoint.X;
        double secondSide = firstPoint.Y - secondPoint.Y;

        double distance = Math.Sqrt((firstSide * firstSide) + (secondSide * secondSide));

        return distance;
    }
}

