using System;
using System.Collections.Generic;
using System.Linq;

public class HornetArmada
{
    public static void Main()
    {
        Dictionary<string, long> legionAndActivity = new Dictionary<string, long>();
        Dictionary<string, Dictionary<string, long>> legionsData = new Dictionary<string, Dictionary<string, long>>();
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] input = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long lastActivity = long.Parse(input[0].Trim());
            string legionName = input[1].Trim();
            string soldierType = input[2].Trim();
            long soldierCount = long.Parse(input[3].Trim());

            if (!legionAndActivity.ContainsKey(legionName) && !legionsData.ContainsKey(legionName))
            {
                legionAndActivity.Add(legionName, lastActivity);
                legionsData.Add(legionName, new Dictionary<string, long>());
            }
            if (!legionsData[legionName].ContainsKey(soldierType))
            {
                legionsData[legionName].Add(soldierType, 0L);
            }

            legionsData[legionName][soldierType] += soldierCount;

            if (legionAndActivity.ContainsKey(legionName))
            {
                long currentActivity = legionAndActivity[legionName];

                if (currentActivity < lastActivity)
                {
                    legionAndActivity[legionName] = lastActivity;
                }
            }
        }

        string[] commands = Console.ReadLine().Split('\\');

        if (commands.Length == 1)
        {
            string neededSoldierType = commands[0];
            Dictionary<string, long> selected = new Dictionary<string, long>();

            foreach (var data in legionsData.Where(t => t.Value.Keys.Contains(neededSoldierType)))
            {
                string currentLegionName = data.Key;
                long currentActivity = legionAndActivity[currentLegionName];
                selected.Add(currentLegionName, currentActivity);
            }

            foreach (var item in selected.OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"{item.Value} : {item.Key}");
            }
        }
        else
        {
            long neededActivity = long.Parse(commands[0]);
            string neededSoldierType = commands[1];
            Dictionary<string, long> selected = new Dictionary<string, long>();

            foreach (var data in legionsData.Where(t => t.Value.Keys.Contains(neededSoldierType)))
            {
                string currentLegionName = data.Key;
                var currentResult = legionsData[currentLegionName].ToArray();
                for (int i = 0; i < currentResult.Length; i++)
                {
                    if (currentResult[i].Key.Equals(neededSoldierType))
                    {
                        long currentSoldierCount = currentResult[i].Value;
                        long currentActivity = legionAndActivity[currentLegionName];

                        if (currentActivity < neededActivity)
                        {
                            selected.Add(currentLegionName, currentSoldierCount);
                        }
                    }
                }
            }

            foreach (var item in selected.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
