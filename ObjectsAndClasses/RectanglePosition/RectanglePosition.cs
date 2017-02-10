using System;
using System.Linq;

public class RectanglePosition
{
    public static void Main()
    {
        Rectangle firstRectangle = ReadRectangle();
        Rectangle secondRectangle = ReadRectangle();

        double firstRectRight = CalculatedRight(firstRectangle);
        double secondRectRight = CalculatedRight(secondRectangle);
        double firstRectBottom = CalculatedBottom(firstRectangle);
        double secondRectBottom = CalculatedBottom(secondRectangle);
        bool isInside = IsInside(firstRectangle, secondRectangle, firstRectRight, secondRectRight, firstRectBottom, secondRectBottom);

        PrintResult(isInside);
    }

    public static void PrintResult(bool isInside)
    {
        if (isInside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }

    public static bool IsInside(Rectangle firstRectangle, Rectangle secondRectangle, double firstRectRight, double secondRectRight, double firstRectBottom, double secondRectBottom)
    {
        bool isInside = (firstRectangle.Left >= secondRectangle.Left) && (firstRectRight <= secondRectRight) && (firstRectangle.Top >= secondRectangle.Top) && (firstRectBottom <= secondRectBottom);

        return isInside;
    }

    public static double CalculatedBottom(Rectangle rectangle)
    {
        return rectangle.Height - rectangle.Top;
    }

    public static double CalculatedRight(Rectangle rectangle)
    {
        return rectangle.Left + rectangle.Width;
    }

    public static Rectangle ReadRectangle()
    {
        double[] rectangleInfo = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        Rectangle rectangle = new Rectangle();
        rectangle.Left = rectangleInfo[0];
        rectangle.Top = rectangleInfo[1];
        rectangle.Width = rectangleInfo[2];
        rectangle.Height = rectangleInfo[3];

        return rectangle;
    }
}
