using System;

class CubeProperties
{
    public static void Main()
    {
        double cubeSide = double.Parse(Console.ReadLine());
        string parameter = Console.ReadLine();

        PrintCubeParameters(cubeSide, parameter);
    }

    public static void PrintCubeParameters(double cubeSide, string parameter)
    {
        switch (parameter)
        {
            case "face":
                double faceDiagonal = Math.Sqrt(2 * (cubeSide * cubeSide));
                Console.WriteLine($"{faceDiagonal:f2}");
                break;
            case "space":
                double spaceDiagonal = Math.Sqrt(3 * (cubeSide * cubeSide));
                Console.WriteLine($"{spaceDiagonal:f2}");
                break;
            case "volume":
                double volume = cubeSide * cubeSide * cubeSide;
                Console.WriteLine($"{volume:f2}");
                break;
            case "area":
                double area = 6 * (cubeSide * cubeSide);
                Console.WriteLine($"{area:f2}");
                break;
        }
    }
}