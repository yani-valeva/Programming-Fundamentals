using System;

class LongerLine
{
    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double a1 = double.Parse(Console.ReadLine());
        double b1 = double.Parse(Console.ReadLine());
        double a2 = double.Parse(Console.ReadLine());
        double b2 = double.Parse(Console.ReadLine());

        double firstLineLength = GetLineLength(x1, y1, x2, y2);
        double secondLineLength = GetLineLength(a1, b1, a2, b2);

        if (firstLineLength >= secondLineLength)
        {
            PrintLongerLine(x1, y1, x2, y2);
        }
        else
        {
            PrintLongerLine(a1, b1, a2, b2);
        }
    }

    public static void PrintLongerLine(double x1, double y1, double x2, double y2)
    {
        double firstDistance = GetLineLength(x1, y1, 0, 0);
        double secondDistance = GetLineLength(x2, y2, 0, 0);
        if (firstDistance <= secondDistance)
        {
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }
    }

    public static double GetLineLength(double x1, double y1, double x2, double y2)
    {
        double lineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return lineLength;
    }
}
