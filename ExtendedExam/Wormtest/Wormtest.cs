using System;

public class Wormtest
{
    public static void Main()
    {
        long wormLength = long.Parse(Console.ReadLine());
        double wormWidth = double.Parse(Console.ReadLine());
        wormLength *= 100;

        if (wormWidth == 0 || wormLength % wormWidth == 0)
        {
            Console.WriteLine("{0:f2}", wormLength * wormWidth);
        }
        else
        {
            Console.WriteLine("{0:f2}%", wormLength * 100 / wormWidth);
        }
    }
}
