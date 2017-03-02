using System;
using System.Collections.Generic;
using System.Linq;

public class CubicAssault
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, long>> regions = new Dictionary<string, Dictionary<string, long>>();
        string input = Console.ReadLine();

        while (!input.Equals("Count em all"))
        {
            string[] inputInfo = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string regionName = inputInfo[0].Trim();
            string meteorType = inputInfo[1].Trim();
            long count = long.Parse(inputInfo[2].Trim());

            if (!regions.ContainsKey(regionName))
            {
                regions.Add(regionName, new Dictionary<string, long>());
            }
            if (!regions[regionName].ContainsKey(meteorType))
            {
                regions[regionName].Add("Black", 0L);
                regions[regionName].Add("Red", 0L);
                regions[regionName].Add("Green", 0L);
            }

            regions[regionName][meteorType] += count;
            long currentCount = regions[regionName][meteorType];

            while (currentCount >= 1000000)
            {
                switch (meteorType)
                {
                   case "Green":
                        long redCount = currentCount / 1000000;
                        long greenCount = currentCount % 1000000;
                        regions[regionName]["Red"] += redCount;
                        regions[regionName][meteorType] = greenCount;
                        break;
                    case "Red":
                        long blackCount = currentCount / 1000000;
                        long redColorCount = currentCount % 1000000;
                        regions[regionName]["Black"] += blackCount;
                        regions[regionName][meteorType] = redColorCount;
                        break;
                }

                currentCount = regions[regionName]["Red"];
                meteorType = "Red";
            }

            input = Console.ReadLine();
        }

        foreach (var region in regions.OrderByDescending(b => b.Value["Black"]).ThenBy(n => n.Key.Length).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{region.Key}");

            var selected = regions[region.Key];

            foreach (var type in selected.OrderByDescending(c => c.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"-> {type.Key} : {type.Value}");
            }
        }
    }
}
