using System;

public class VaporStore
{
    public static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        string game = Console.ReadLine();
        decimal spentMoney = 0m;
        decimal gamePrice = 0m;

        if (money == 0)
        {
            Console.WriteLine("Out of money!");
            return;
        }

        while (game != "Game Time")
        {
            switch (game)
            {
                case "OutFall 4":
                    gamePrice = 39.99m;
                    break;
                case "CS: OG":
                    gamePrice = 15.99m;
                    break;
                case "Zplinter Zell":
                    gamePrice = 19.99m;
                    break;
                case "Honored 2":
                    gamePrice = 59.99m;
                    break;
                case "RoverWatch":
                    gamePrice = 29.99m;
                    break;
                case "RoverWatch Origins Edition":
                    gamePrice = 39.99m;
                    break;
                default:
                    gamePrice = 0m;
                    break;
            }

            if (gamePrice == 0)
            {
                Console.WriteLine("Not Found");
            }
            else if (money < gamePrice)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                Console.WriteLine($"Bought {game}");
                money -= gamePrice;
                spentMoney += gamePrice;
            }
            if (money == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }

            game = Console.ReadLine();
        }

        Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${money:f2}");
    }
}
