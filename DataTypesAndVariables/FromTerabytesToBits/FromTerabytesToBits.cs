using System;

public class FromTerabytesToBits
{
    public static void Main()
    {
        decimal terabytes = decimal.Parse(Console.ReadLine());
        decimal bits = terabytes * 1024 * 1024 * 1024 * 1024 * 8;

        Console.WriteLine($"{bits:f0}");
    }
}
