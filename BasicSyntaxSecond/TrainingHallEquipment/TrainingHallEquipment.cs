using System;

public class TrainingHallEquipment
{
    public static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        int itemsNumber = int.Parse(Console.ReadLine());

        decimal totalSum = 0m;

        for (int i = 0; i < itemsNumber; i++)
        {
            string itemName = Console.ReadLine();
            decimal itemPrice = decimal.Parse(Console.ReadLine());
            int itemCount = int.Parse(Console.ReadLine());

            string nameByCount = itemCount > 1 ? $"{itemName}s" : $"{itemName}";

            Console.WriteLine($"Adding {itemCount} {nameByCount} to cart.");
            totalSum += itemCount * itemPrice;
        }

        decimal diff = budget - totalSum;
        Console.WriteLine($"Subtotal: ${totalSum:f2}");
        Console.WriteLine(diff >= 0 ? $"Money left: ${diff:f2}" : $"Not enough. We need ${Math.Abs(diff):f2} more.");
    }
}
