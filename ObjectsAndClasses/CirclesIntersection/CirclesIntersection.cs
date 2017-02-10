using System;
using System.Linq;

public class CirclesIntersection
{
    public static void Main()
    {
        Circle firstCircleCoordinates = ReadCircleCoordinates();
        Circle secondCircleCoordinates = ReadCircleCoordinates();
        double distance = GetDistanceBetweenCirclesCenters(firstCircleCoordinates, secondCircleCoordinates);
        bool isIntersect = IsIntersect(firstCircleCoordinates, secondCircleCoordinates, distance);

        PrintResult(isIntersect);      
    }

    public static void PrintResult (bool isIntersect)
    {
        if (isIntersect)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    } 

    public static bool IsIntersect(Circle firstCircleCoordinates, Circle secondCircleCoordinates, double distance)
    {
        bool isIntersect = false;
        double sumOfRadouses = firstCircleCoordinates.Radius + secondCircleCoordinates.Radius;

        if (distance <= sumOfRadouses)
        {
            isIntersect = true;
        }

        return isIntersect;
    }

    public static double GetDistanceBetweenCirclesCenters(Circle firstCircleCoordinates, Circle secondCircleCoordinates)
    {
        double deltaX = firstCircleCoordinates.Center.X - secondCircleCoordinates.Center.X;
        double deltaY = firstCircleCoordinates.Center.Y - secondCircleCoordinates.Center.Y;
        double distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));

        return distance;
    }

    public static Circle ReadCircleCoordinates()
    {
        double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        Point point = new Point();
        point.X = input[0];
        point.Y = input[1];

        Circle circle = new Circle();
        circle.Center = point;
        circle.Radius = input[2];

        return circle;
    }
}