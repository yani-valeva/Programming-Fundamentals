using System;

public class Megapixels
{
    public static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double megapixels = Math.Round((width * height) / 1000000.0, 1);

        Console.WriteLine($"{width}x{height} => {megapixels}MP");
    }
}
