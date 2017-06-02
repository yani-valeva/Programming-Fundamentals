using System;

public class CaloriesCounter
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalCalories = 0;
        for (int i = 0; i < n; i++)
        {
            String ingredient = Console.ReadLine().ToLower();

            switch (ingredient)
            {
                case "cheese":
                    totalCalories += 500;
                    break;
                case "tomato sauce":
                    totalCalories += 150;
                    break;
                case "salami":
                    totalCalories += 600;
                    break;
                case "pepper":
                    totalCalories += 50;
                    break;
            }
        }

        Console.WriteLine($"Total calories: {totalCalories}");
    }
}