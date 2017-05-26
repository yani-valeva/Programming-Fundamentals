using System;

public class CharacterStats
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int currentHealth = int.Parse(Console.ReadLine());
        int maximumHealth = int.Parse(Console.ReadLine());
        int currentEnergy = int.Parse(Console.ReadLine());
        int maximumEnergy = int.Parse(Console.ReadLine());

        int healthDiff = maximumHealth - currentHealth;
        int energyDiff = maximumEnergy - currentEnergy;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health: |{new string('|', currentHealth)}{new string('.', healthDiff)}|");
        Console.WriteLine($"Energy: |{new string('|', currentEnergy)}{new string('.', energyDiff)}|");
    }
}
