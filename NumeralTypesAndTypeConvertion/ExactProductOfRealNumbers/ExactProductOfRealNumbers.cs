using System;

public class ExactProductOfRealNumbers
{
    public static void Main()
    {
        int numberCount = int.Parse(Console.ReadLine());
        decimal product = 1m;

        for (int i = 0; i < numberCount; i++)
        {
            decimal currentNumber = decimal.Parse(Console.ReadLine());
            product *= currentNumber;
        }

        Console.WriteLine(product);
    }
}
