using System;

public class SoftUniAirline
{
    public static void Main()
    {
        int flightsNumber = int.Parse(Console.ReadLine());
        decimal overallProfit = 0;        

        for (int i = 0; i < flightsNumber; i++)
        {
            long adultPassengersCount = long.Parse(Console.ReadLine());
            decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
            long youthPassengersCount = long.Parse(Console.ReadLine());
            decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
            decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
            decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
            int flightDuration = int.Parse(Console.ReadLine());

            decimal incomes = (adultPassengersCount * adultTicketPrice) + (youthPassengersCount * youthTicketPrice);
            decimal expenses = flightDuration * fuelConsumptionPerHour * fuelPricePerHour;
            decimal profit = incomes - expenses;
            overallProfit += profit;

            if (incomes >= expenses)
            {                
                Console.WriteLine($"You are ahead with {profit:f3}$.");
            }
            else
            {
                Console.WriteLine($"We've got to sell more tickets! We've lost {profit:f3}$.");
            }
        }

        decimal averageProfit = overallProfit / flightsNumber;

        Console.WriteLine($"Overall profit -> {overallProfit:f3}$.");
        Console.WriteLine($"Average profit -> {averageProfit:f3}$.");
    }
}
