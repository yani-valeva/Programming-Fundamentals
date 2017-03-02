using System;

public class SweetDessert
{
    public static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        long numberOfGuests = long.Parse(Console.ReadLine());
        decimal bananaPrice = decimal.Parse(Console.ReadLine());
        decimal eggPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPricePerKg = decimal.Parse(Console.ReadLine());

        long setCount = numberOfGuests / 6;

        if (numberOfGuests % 6 != 0)
        {
            setCount++;
        }

        decimal neededMoney = setCount * ((2 * bananaPrice) + (4 * eggPrice) + (0.2m * berriesPricePerKg));

        if (neededMoney <= money)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:f2}lv.");
        }
        else
        {
            decimal difference = neededMoney - money;

            Console.WriteLine($"Ivancho will have to withdraw money - he will need {difference:f2}lv more.");
        }
    }
}
