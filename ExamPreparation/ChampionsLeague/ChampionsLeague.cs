using System;
using System.Collections.Generic;
using System.Linq;

public class ChampionsLeague
{
    public static void Main()
    {
        Dictionary<string, int> teamsAndTotalWins = new Dictionary<string, int>();
        Dictionary<string, List<string>> teamAndOpponentTeams = new Dictionary<string, List<string>>();
        string input = Console.ReadLine();

        while (!input.Equals("stop"))
        {
            string[] inputInfo = input.Split('|');
            string firstTeam = inputInfo[0].Trim();
            string secondTeam = inputInfo[1].Trim();
            string[] firstMatchResult = inputInfo[2].Trim().Split(':');
            string[] secondMatchResult = inputInfo[3].Trim().Split(':');
            int firstTeamGoalsInFirstMatch = int.Parse(firstMatchResult[0]);
            int firstTeamGoalsInSecondMatch = int.Parse(secondMatchResult[1]);
            int secondTeamGoalsInFirstMatch = int.Parse(firstMatchResult[1]);
            int secondTeamGoalsInSecondMatch = int.Parse(secondMatchResult[0]);
            int firstTeamGoals = firstTeamGoalsInFirstMatch + firstTeamGoalsInSecondMatch;
            int secondTeamGoals = secondTeamGoalsInFirstMatch + secondTeamGoalsInSecondMatch;
            int firstTeamPoint = 0;
            int secondTeamPoint = 0;

            if (firstTeamGoals > secondTeamGoals)
            {
                firstTeamPoint = 1;
            }
            else if (firstTeamGoals < secondTeamGoals)
            {
                secondTeamPoint = 1;
            }
            else
            {
                if (secondTeamGoalsInFirstMatch > firstTeamGoalsInSecondMatch)
                {
                    secondTeamPoint = 1;
                }
                else if (secondTeamGoalsInFirstMatch < firstTeamGoalsInSecondMatch)
                {
                    firstTeamPoint = 1;
                }
            }

            if (!teamsAndTotalWins.ContainsKey(firstTeam) && !teamAndOpponentTeams.ContainsKey(firstTeam))
            {
                teamsAndTotalWins.Add(firstTeam, 0);
                teamAndOpponentTeams.Add(firstTeam, new List<string>());
            }

            teamsAndTotalWins[firstTeam] += firstTeamPoint;
            teamAndOpponentTeams[firstTeam].Add(secondTeam);

            if (!teamsAndTotalWins.ContainsKey(secondTeam) && !teamAndOpponentTeams.ContainsKey(secondTeam))
            {
                teamsAndTotalWins.Add(secondTeam, 0);
                teamAndOpponentTeams.Add(secondTeam, new List<string>());
            }

            teamsAndTotalWins[secondTeam] += secondTeamPoint;
            teamAndOpponentTeams[secondTeam].Add(firstTeam);

            input = Console.ReadLine();
        }

        foreach (var team in teamsAndTotalWins.OrderByDescending(w => w.Value).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{team.Key}");
            Console.WriteLine($"- Wins: {team.Value}");

            var selectedOppenents = teamAndOpponentTeams[team.Key].OrderBy(n => n).ToList();

            Console.WriteLine($"- Opponents: {string.Join(", ", selectedOppenents)}");
        }
    }
}
