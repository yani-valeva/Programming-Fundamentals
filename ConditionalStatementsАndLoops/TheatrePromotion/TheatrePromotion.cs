using System;

public class TheatrePromotion
{
    public static void Main()
    {
        string dayType = Console.ReadLine().ToLower();
        int age = int.Parse(Console.ReadLine());

        int ticketPrice = 0;

        if (age < 0 || age > 122)
        {
            Console.WriteLine("Error!");
            return;
        }

        switch (dayType)
        {
            case "weekday":
                if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                {
                    ticketPrice = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 18;
                }
                break;
            case "weekend":
                if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                {
                    ticketPrice = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 20;
                }
                break;
            case "holiday":
                if (age >= 0 && age <= 18)
                {
                    ticketPrice = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    ticketPrice = 10;
                }
                break;
        }

        Console.WriteLine($"{ticketPrice}$");
    }
}
