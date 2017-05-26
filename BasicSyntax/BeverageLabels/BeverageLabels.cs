using System;

public class BeverageLabels
{
    public static void Main()
    {
        string productName = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energy = int.Parse(Console.ReadLine());
        int sugar = int.Parse(Console.ReadLine());

        double energyContent = (energy / 100.0) * volume;
        double sugarContent = (sugar / 100.0) * volume;
 
        Console.WriteLine($"{volume}ml {productName}:");
        Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
    }
}
