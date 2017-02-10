using System;
using System.Collections.Generic;

public class SalesReport
{
    public static void Main()
    {
        int numberOfSales = int.Parse(Console.ReadLine());
        SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

        for (int i = 0; i < numberOfSales; i++)
        {          
           Sale currentSale = ReadSale();
            
            if (!salesByTown.ContainsKey(currentSale.Town))
            {
                salesByTown.Add(currentSale.Town, 0);
            }

            salesByTown[currentSale.Town] += currentSale.Price * currentSale.Quantity;           
        }

        foreach (var town in salesByTown)
        {
            Console.WriteLine($"{town.Key} -> {town.Value:f2}");
        }
    }

    public static Sale ReadSale()
    {
        string[] input = Console.ReadLine().Split(' ');
        Sale sale = new Sale();
        sale.Town = input[0];
        sale.Product = input[1];
        sale.Price = decimal.Parse(input[2]);
        sale.Quantity = decimal.Parse(input[3]);

        return sale;
    }
}