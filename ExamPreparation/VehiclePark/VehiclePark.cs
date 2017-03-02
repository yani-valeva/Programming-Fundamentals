using System;
using System.Collections.Generic;
using System.Linq;

public class VehiclePark
{
    public static void Main()
    {
        List<string> vehicles = Console.ReadLine().Split(' ').ToList();
        string input = Console.ReadLine();
        int soldVehiclesCount = 0;

        while (!input.Equals("End of customers!"))
        {
            string[] inputInfo = input.Split(' ');
            string vehicleTypeInfo = inputInfo[0].ToLower();
            int numberOfSeats = int.Parse(inputInfo[2]);
            char vehicleType = vehicleTypeInfo[0];
            bool isFound = false;

            for (int i = 0; i < vehicles.Count; i++)
            {
                char currentVehicleType = vehicles[i][0];
                int currentSeatsCount = int.Parse(vehicles[i].Substring(1));

                if (currentVehicleType == vehicleType && currentSeatsCount == numberOfSeats)
                {
                    int currentVehiclePrice = currentVehicleType * currentSeatsCount;
                    soldVehiclesCount++;
                    isFound = true;
                    vehicles.RemoveAt(i);
                    Console.WriteLine($"Yes, sold for {currentVehiclePrice}$");
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"Vehicles left: {string.Join(", ", vehicles)}");
        Console.WriteLine($"Vehicles sold: {soldVehiclesCount}");
    }
}
