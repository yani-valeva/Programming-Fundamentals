using System;

class CalculateTriangleArea
{
    public static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = GetTriangleArea(side, height);
        Console.WriteLine(area);
    }

    public static double GetTriangleArea(double side, double height)
    {
        double area = (side * height) / 2.0;
        return area;
    }
}
