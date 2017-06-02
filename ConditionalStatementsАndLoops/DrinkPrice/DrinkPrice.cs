using System;

public class DrinkPrice
{
    public static void Main()
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        switch (profession)
        {
            case "Athlete":
                Console.WriteLine($"The {profession} has to pay {quantity * 0.70:f2}.");
                break;
            case "Businessman":
            case "Businesswoman":
                Console.WriteLine($"The {profession} has to pay {quantity * 1.0:f2}.");
                break;
            case "SoftUni Student":
                Console.WriteLine($"The {profession} has to pay {quantity * 1.70:f2}.");
                break;
            default:
                Console.WriteLine($"The {profession} has to pay {quantity * 1.20:f2}.");
                break;
        }
    }
}
