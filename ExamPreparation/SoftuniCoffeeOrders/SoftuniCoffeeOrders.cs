using System;
using System.Globalization;

public class SoftuniCoffeeOrders
{
    public static void Main()
    {
        int numberOfOrders = int.Parse(Console.ReadLine());
        decimal totalPrice = 0m;

        for (int i = 0; i < numberOfOrders; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string dateAsStrint = Console.ReadLine();
            DateTime orderDate = DateTime.ParseExact(dateAsStrint, "d/M/yyyy", CultureInfo.InvariantCulture);
            decimal capsulesCount = decimal.Parse(Console.ReadLine());
            var year = orderDate.Year;
            var month = orderDate.Month;
            int days = DateTime.DaysInMonth(year, month);
            decimal currentPrice = (days * capsulesCount) * pricePerCapsule;
            totalPrice += currentPrice;

            Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
        }

        Console.WriteLine($"Total: ${totalPrice:f2}");
    }
}
