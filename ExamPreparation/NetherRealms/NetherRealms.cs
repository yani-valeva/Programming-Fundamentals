using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class NetherRealms
{
    public static void Main()
    {
        List<Demon> demons = new List<Demon>();
        string[] input = Console.ReadLine().Split(new char[] { ',', ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < input.Length; i++)
        {
            string demonName = input[i];
            int health = 0;
            double damage = 0;
            string firstPattern = @"[^0-9\+-\/*\.]";
            string secondPattern = @"[-|\+]?[0-9]*\.*[0-9]+";

            Regex regex = new Regex(firstPattern);
            MatchCollection letters = regex.Matches(demonName);

            foreach (Match item in letters)
            {
                char letterAsString = char.Parse(item.ToString());
                int letterValue = (int)letterAsString;
                health += letterValue;            
            }

            Regex reg = new Regex(secondPattern);
            MatchCollection numbers = reg.Matches(demonName);

            foreach (var number in numbers)
            {
                string numberAsString = number.ToString();

                if (numberAsString[0] == '-')
                {
                    numberAsString = numberAsString.Remove(0, 1);
                    damage += double.Parse(numberAsString) * -1;
                }
                else if (numberAsString[0] == '+')
                {
                    numberAsString = numberAsString.Remove(0, 1);
                    damage += double.Parse(numberAsString);
                }
                else
                {
                    damage += double.Parse(numberAsString);
                }
            }

            for (int j = 0; j < demonName.Length; j++)
            {
                if (demonName[j] == '*')
                {
                    damage *= 2;
                }
                else if (demonName[j] == '/')
                {
                    damage /= 2;
                }
            }

            Demon demon = new Demon();
            demon.Name = demonName;
            demon.Health = health;
            demon.Damage = damage;
            demons.Add(demon);
        }

        foreach (var demon in demons.OrderBy(d => d.Name))
        {
            Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
        }
    }
}
