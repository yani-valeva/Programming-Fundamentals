using System;
using System.Linq;

public class ClosestTwoPoints
{
    public static void Main()
    {
        int numberOfPoints = int.Parse(Console.ReadLine());
        Point[] points = new Point[numberOfPoints];

        for (int i = 0; i < numberOfPoints; i++)
        {            
            Point point = ReadPoint();
            points[i] = point;
        }

        PrintClosestPointsDistance(points);

    }

    public static void PrintClosestPointsDistance (Point[] points)
    {
        double minDistance = double.MaxValue;
        Point first = points[0];
        Point second = points[1];

        for (int i = 0; i < points.Length - 1; i++)
        {
            Point firstPoint = points[i];

            for (int j = i + 1; j < points.Length; j++)
            {
                Point secondPoint = points[j];

                double currentDistance = CalculateDistance(firstPoint, secondPoint);

                if (minDistance > currentDistance)
                {
                    minDistance = currentDistance;

                    first = firstPoint;
                    second = secondPoint;
                }

            }
        }

        Console.WriteLine($"{minDistance:f3}");
        Console.WriteLine($"({first.X}, {first.Y})");
        Console.WriteLine($"({second.X}, {second.Y})");
    }

    public static double CalculateDistance(Point firstPoint, Point secondPoint)
    {
        double firstSide = firstPoint.X - secondPoint.X;
        double secondSide = firstPoint.Y - secondPoint.Y;

        double distance = Math.Sqrt((firstSide * firstSide) + (secondSide * secondSide));

        return distance;
    }

    public static Point ReadPoint()
    {
        double[] pointInfo = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        Point point = new Point();
        point.X = pointInfo[0];
        point.Y = pointInfo[1];

        return point;
    }
}