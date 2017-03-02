using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class AshesOfRoses
{
    public static void Main()
    {
        //90/100
        string input = Console.ReadLine();
        string firstPattern = @"<[A-Z][a-z]*>";
        string secondPattern = @"<[a-zA-Z0-9]+>";
        string thirdInput = @"\d+";
        Dictionary<string, Dictionary<string, long>> rosesByRegion = new Dictionary<string, Dictionary<string, long>>();

        while (!input.Equals("Icarus, Ignite!"))
        {
            string[] inputInfo = input.Split(' ');

            bool isValid = IsValid(inputInfo, firstPattern, secondPattern, thirdInput);

            if (!isValid)
            {
                input = Console.ReadLine();
                continue;
            }

            string regionName = inputInfo[1].Trim('<', '>');
            string colorName = inputInfo[2].Trim('<', '>');
            long roseAmount = long.Parse(inputInfo[3]);

            if (!rosesByRegion.ContainsKey(regionName))
            {
                rosesByRegion.Add(regionName, new Dictionary<string, long>());
            }
            if (!rosesByRegion[regionName].ContainsKey(colorName))
            {
                rosesByRegion[regionName].Add(colorName, 0L);
            }

            rosesByRegion[regionName][colorName] += roseAmount;

            input = Console.ReadLine();
        }

        foreach (var region in rosesByRegion.OrderByDescending(a => a.Value.Values.Sum()).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{region.Key}");

            var selectedByRegion = rosesByRegion[region.Key];

            foreach (var color in selectedByRegion.OrderBy(a => a.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"*--{color.Key} | {color.Value}");
            }
        }
    }

    public static bool IsValid(string[] inputInfo, string firstPattern, string secondPattern, string thirdPattern)
    {
        bool isValid = true;
    
        if (inputInfo[0] != "Grow")
        {
            return false;
        }

        Regex regex = new Regex(firstPattern);
        bool isMatch = regex.IsMatch(inputInfo[1]);

        if (!isMatch)
        {
            return false;
        }

        Regex reg = new Regex(secondPattern);
        bool isFound = reg.IsMatch(inputInfo[2]);

        if (!isFound)
        {
            return false;
        }

        Regex rgx = new Regex(thirdPattern);
        MatchCollection matches = rgx.Matches(inputInfo[3]);
        int count = 0;

        foreach (Match match in matches)
        {
            count++;
        }

        if (count > 1)
        {
            return false;
        }

        return isValid;
    }
}
