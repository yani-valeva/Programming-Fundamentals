using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniCoffeeSupplies
{
    public static void Main()
    {
        string[] delimiters = Console.ReadLine().Split(' ');
        string firstDelimiter = delimiters[0];
        string secondDelimiter = delimiters[1];
        string input = Console.ReadLine();
        Dictionary<string, string> teamMemberAndCoffeeType = new Dictionary<string, string>();
        Dictionary<string, long> coffeeTypeAndQuantity = new Dictionary<string, long>();

        while (!input.Equals("end of info"))
        {
            if (input.Contains(firstDelimiter))
            {
                int index = input.IndexOf(firstDelimiter);
                string name = input.Substring(0, index);
                index += firstDelimiter.Length;
                string coffeeType = input.Substring(index);

                if (!teamMemberAndCoffeeType.ContainsKey(name))
                {
                    teamMemberAndCoffeeType.Add(name, null);
                }

                teamMemberAndCoffeeType[name] = coffeeType;
            }
            else if (input.Contains(secondDelimiter))
            {
                int index = input.IndexOf(secondDelimiter);
                string coffeeType = input.Substring(0, index);
                index += secondDelimiter.Length;
                long quantity = long.Parse(input.Substring(index));

                if (!coffeeTypeAndQuantity.ContainsKey(coffeeType))
                {
                    coffeeTypeAndQuantity.Add(coffeeType, 0);
                }

                coffeeTypeAndQuantity[coffeeType] += quantity;
            }

            input = Console.ReadLine();           
        }

        foreach (var member in teamMemberAndCoffeeType)
        {
            string typeOfCoffee = member.Value;

            if (!coffeeTypeAndQuantity.ContainsKey(typeOfCoffee) || coffeeTypeAndQuantity[typeOfCoffee] == 0)
            {
                Console.WriteLine($"Out of {typeOfCoffee}");
            }
        }

        string line = Console.ReadLine();

        while (!line.Equals("end of week"))
        {
            string[] lineInfo = line.Split(' ');
            string memberName = lineInfo[0];
            long coffeeCount = long.Parse(lineInfo[1]);
            string currentCoffeeType = teamMemberAndCoffeeType[memberName];
            long currentCoffeeQuantity = coffeeTypeAndQuantity[currentCoffeeType] - coffeeCount;

            if (currentCoffeeQuantity < 1)
            {
                Console.WriteLine($"Out of {currentCoffeeType}");
            }

            coffeeTypeAndQuantity[currentCoffeeType] = currentCoffeeQuantity;
            line = Console.ReadLine();
        }

        Console.WriteLine("Coffee Left:");

        SortedDictionary<string, HashSet<string>> selected = new SortedDictionary<string, HashSet<string>>();

        foreach (var coffee in coffeeTypeAndQuantity.Where(q => q.Value > 0).OrderByDescending(kq => kq.Value))
        {
            string coffeeName = coffee.Key;
            Console.WriteLine($"{coffee.Key} {coffee.Value}");

            foreach (var item in teamMemberAndCoffeeType)
            {
                if (item.Value == coffeeName)
                {
                    if (!selected.ContainsKey(coffeeName))
                    {
                        selected.Add(coffeeName, new HashSet<string>());
                    }

                    selected[coffeeName].Add(item.Key);
                }
            }
        }

        Console.WriteLine("For:");

        foreach (var item in selected)
        {
            string coffee = item.Key;

            var orderedMembers = item.Value;

            foreach (var member in orderedMembers.OrderByDescending(n => n))
            {
                Console.WriteLine($"{member} {coffee}");
            }
        }
    }
}
