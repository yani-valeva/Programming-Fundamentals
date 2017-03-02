using System;

public class GameOfNames
{
    public static void Main()
    {
        int playersCount = int.Parse(Console.ReadLine());
        long maxPoints = long.MinValue;
        string winner = string.Empty;

        for (int i = 0; i < playersCount; i++)
        {
            string playerName = Console.ReadLine();
            long points = long.Parse(Console.ReadLine());           

            for (int j = 0; j < playerName.Length; j++)
            {
                int currentPoints = playerName[j];

                if (currentPoints % 2 == 0)
                {
                    points += currentPoints;
                }
                else
                {
                    points -= currentPoints;
                }
            }

            if (maxPoints < points)
            {
                maxPoints = points;
                winner = playerName;
            }
        }

        Console.WriteLine($"The winner is {winner} - {maxPoints} points");
    }
}
