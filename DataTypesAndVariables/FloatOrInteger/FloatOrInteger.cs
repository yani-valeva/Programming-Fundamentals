using System;

public class FloatOrInteger
{
    public static void Main()
    {
        int number = (int)Math.Round(double.Parse(Console.ReadLine()));
        Console.WriteLine(number);
    }
}