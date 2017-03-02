using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

public class FootballLeague
{
    public static void Main()
    {
        string key = Console.ReadLine();
        string input = Console.ReadLine();
        Dictionary<string, long> teamsAndPoints = new Dictionary<string, long>();
        Dictionary<string, long> teamsAndGoals = new Dictionary<string, long>();

        while (!input.Equals("final"))
        {
            int firstIndex = input.IndexOf(key, 0);
            int nextIndex = input.IndexOf(key, firstIndex + 1);
            string firstTeamName = input.Substring(firstIndex + key.Length, nextIndex - (firstIndex + key.Length)).ToUpper();
            firstIndex = input.IndexOf(key, nextIndex + key.Length);
            nextIndex = input.IndexOf(key, firstIndex + 1);
            string secondTeamName = input.Substring(firstIndex + key.Length, nextIndex - (firstIndex + key.Length)).ToUpper();
            firstTeamName = GetTeamName(firstTeamName);
            secondTeamName = GetTeamName(secondTeamName);
            string pattern = @"(\d+):(\d+)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            long firstTeamGoals = long.Parse(match.Groups[1].Value);
            long secondTeamGoals = long.Parse(match.Groups[2].Value);
            long firstTeamPoints = 0;
            long secondTeamPoints = 0;

            if (firstTeamGoals > secondTeamGoals)
            {
                firstTeamPoints += 3;
            }
            else if (firstTeamGoals < secondTeamGoals)
            {
                secondTeamPoints += 3;
            }
            else
            {
                firstTeamPoints += 1;
                secondTeamPoints += 1;
            }

            if (!teamsAndPoints.ContainsKey(firstTeamName) && !teamsAndGoals.ContainsKey(firstTeamName))
            {
                teamsAndPoints.Add(firstTeamName, 0L);
                teamsAndGoals.Add(firstTeamName, 0L);
            }

            teamsAndPoints[firstTeamName] += firstTeamPoints;
            teamsAndGoals[firstTeamName] += firstTeamGoals;

            if (!teamsAndPoints.ContainsKey(secondTeamName) && !teamsAndGoals.ContainsKey(secondTeamName))
            {
                teamsAndPoints.Add(secondTeamName, 0L);
                teamsAndGoals.Add(secondTeamName, 0L);
            }

            teamsAndPoints[secondTeamName] += secondTeamPoints;
            teamsAndGoals[secondTeamName] += secondTeamGoals;

            input = Console.ReadLine();
        }

        Console.WriteLine($"League standings:");

        int place = 1;

        foreach (var team in teamsAndPoints.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{place}. {team.Key} {team.Value}");
            place++;
        }

        Console.WriteLine($"Top 3 scored goals:");

        place = 1;

        foreach (var team in teamsAndGoals.OrderByDescending(g => g.Value).ThenBy(n => n.Key).Take(3))
        {
            Console.WriteLine($"- {team.Key} -> {team.Value}");
        }
    }

    public static string GetTeamName(string currentTeamName)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = currentTeamName.Length - 1; i >= 0; i--)
        {
            sb.Append(currentTeamName[i]);
        }

        return currentTeamName = sb.ToString();
    }
}