using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class NetherRealms
{
    public static void Main()
    {
        string firstPattern = @"[^\d\+\-\*\/\.]";
        string secondPattern = @"[\+|\-]?[\d+\.]*[\d]+";
        string[] input = Console.ReadLine().Split(new char[] { ',', ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        List<Demon> demons = new List<Demon>();

        for (int i = 0; i < input.Length; i++)
        {
            string currentDemon = input[i];
            int health = 0;
            double damage = 0;
            Regex regex = new Regex(firstPattern);
            MatchCollection firstMatches = regex.Matches(currentDemon);

            foreach (Match match in firstMatches)
            {
                char currentSymbol = char.Parse(match.Groups[0].Value);
                health += currentSymbol;
            }

            Regex rgx = new Regex(secondPattern);
            MatchCollection secondMatches = rgx.Matches(currentDemon);

            foreach (Match match in secondMatches)
            {
                bool isPositive = true;
                string currentMatch = match.Groups[0].Value;

                if (currentMatch.StartsWith("+"))
                {
                    currentMatch = currentMatch.TrimStart('+');
                }
                else if (currentMatch.StartsWith("-"))
                {
                    currentMatch = currentMatch.TrimStart('-');
                    isPositive = false;
                }

                double currentNumber = double.Parse(currentMatch);

                if (!isPositive)
                {
                    currentNumber *= -1;
                }

                damage += currentNumber;
            }

            for (int j = 0; j < currentDemon.Length; j++)
            {
                if (currentDemon[j] == '/')
                {
                    damage /= 2;
                }
                else if (currentDemon[j] == '*')
                {
                    damage *= 2;
                }
            }

            Demon demon = new Demon();
            demon.Name = currentDemon;
            demon.Health = health;
            demon.Damage = damage;
            demons.Add(demon);
        }

        foreach (var demon in demons.OrderBy(n => n.Name))
        {
            Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage ");
        }
    }
}

