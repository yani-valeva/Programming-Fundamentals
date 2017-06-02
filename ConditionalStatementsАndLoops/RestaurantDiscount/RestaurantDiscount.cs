using System;

public class RestaurantDiscount
{
    public static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        string servicePackage = Console.ReadLine();
        decimal hallPrice = 0m;
        string hallName = "";

        if (people <= 50)
        {
            hallPrice = 2500;
            hallName = "Small Hall";
        }
        else if (people <= 100)
        {
            hallPrice = 5000;
            hallName = "Terrace";
        }
        else if (people <= 120)
        {
            hallPrice = 7500;
            hallName = "Great Hall";
        }
        else
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return;
        }

        decimal discount = 0m;
        decimal packagePrice = 0m;

        switch (servicePackage)
        {
            case "Normal":
                discount = 0.05m;
                packagePrice = 500;
                break;
            case "Gold":
                discount = 0.1m;
                packagePrice = 750;
                break;
            case "Platinum":
                discount = 0.15m;
                packagePrice = 1000;
                break;
        }

        decimal totalPrice = (hallPrice + packagePrice) - ((hallPrice + packagePrice) * discount);
        decimal pricePerPerson = totalPrice / people;

        Console.WriteLine($"We can offer you the {hallName}");
        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
    }
}
