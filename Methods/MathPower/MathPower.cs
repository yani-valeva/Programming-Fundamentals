using System;

class MathPower
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        Console.WriteLine(RaiseToPower(number, power));
    }

    public static double RaiseToPower(double number, int power)
    {
        return Math.Pow(number, power);
    }
}
