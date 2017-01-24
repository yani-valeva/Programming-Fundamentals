using System;

class GeometryCalculator
{
    public static void Main()
    {
        string figureType = Console.ReadLine();

        PrintFigureArea(figureType);
    }

    public static void PrintFigureArea(string figureType)
    {
        if (figureType == "triangle")
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = side * height / 2.0;

            Console.WriteLine($"{area:f2}");
        }
        else if (figureType == "square")
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;

            Console.WriteLine($"{area:f2}");
        }
        else if (figureType == "rectangle")
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;

            Console.WriteLine($"{area:f2}");
        }
        else if (figureType == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * (radius * radius);

            Console.WriteLine($"{area:f2}");
        }        
    }
}
