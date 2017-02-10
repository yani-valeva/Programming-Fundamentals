using System;
using System.Collections.Generic;
using System.Linq;

public class TeamworkProjects
{
    public static void Main()
    {
        int teamsCount = int.Parse(Console.ReadLine());
        List<Team> teams = new List<Team>();

        for (int i = 0; i < teamsCount; i++)
        {
            string[] usersAndTeamsInfo = Console.ReadLine().Split('-');
            string userName = usersAndTeamsInfo[0];
            string teamName = usersAndTeamsInfo[1];

            if (teams.Any(t => t.TeamName == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }
            if (teams.Any(c => c.CreatorName == userName))
            {
                Console.WriteLine($"{userName} cannot create another team!");
                continue;
            }
            if (!teams.Any(t => t.TeamName == teamName))
            {
                Team team = new Team();
                team.CreatorName = userName;
                team.TeamName = teamName;
                team.Members = new List<string>();
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {userName}!");
            }
            
        }

        string memberAndTeamInfo = Console.ReadLine();

        while (!memberAndTeamInfo.Equals("end of assignment"))
        {
            string[] memberAndTeam = memberAndTeamInfo.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            string memberName = memberAndTeam[0];
            string teamName = memberAndTeam[1];
            
            if (teams.All(t => t.TeamName != teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
            }
            else if (teams.Any(m => m.Members.Contains(memberName)) || teams.Any(c => c.CreatorName.Equals(memberName)))
            {
                Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
            }
            else if (teams.Any(t => t.TeamName == teamName))
            {
                foreach (var team in teams)
                {
                    if (team.TeamName == teamName)
                    {
                        team.Members.Add(memberName);
                        break;
                    }
                }
            }
              
            memberAndTeamInfo = Console.ReadLine();
        }

        foreach (var team in teams.Where(m => m.Members.Count > 0).OrderByDescending(m => m.Members.Count).ThenBy(n => n.TeamName))
        {
            Console.WriteLine(team.TeamName);
            Console.WriteLine($"- {team.CreatorName}");

            var selectedTeams = team.Members;

            foreach (var member in selectedTeams.OrderBy(m => m))
            {
                Console.WriteLine($"-- {member}");
            }
        }

        Console.WriteLine("Teams to disband:");

        foreach (var team in teams.Where(m => m.Members.Count == 0).OrderBy(n => n.TeamName))
        {
            Console.WriteLine($"{team.TeamName}");
        }
    }
}
