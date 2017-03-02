using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class FootballLeague
{
    public static void Main()
    {
        string key = Console.ReadLine();
        string pattern = @"(\d+):(\d+)";
        string input = Console.ReadLine();
        Dictionary<string, long> countriesAndPoints = new Dictionary<string, long>();
        Dictionary<string, long> countriesAndGoals = new Dictionary<string, long>();
          
        while (!input.Equals("final"))
        {
            string firstCountry = string.Empty;
            string secondCountry = string.Empty;
            int index = 0;

            for (int i = 0; i < 2; i++)
            {
                int firstIndex = input.IndexOf(key, index);
                int nextIndex = input.IndexOf(key, firstIndex + 1);
                firstIndex += key.Length;
                int length = nextIndex - firstIndex;
                index = nextIndex + 1;

                if (i == 0)
                {
                    string firstCountryReversed = input.Substring(firstIndex, length).ToUpper();
                    
                    for (int j = firstCountryReversed.Length - 1; j >= 0; j--)
                    {
                        firstCountry += firstCountryReversed[j];
                    }                   
                }
                else
                {
                    string secondCountryReversed = input.Substring(firstIndex, length).ToUpper();

                    for (int j = secondCountryReversed.Length - 1; j >= 0; j--)
                    {
                        secondCountry += secondCountryReversed[j];
                    }
                }
            }
            
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            long firstTeamGoals = long.Parse(match.Groups[1].ToString());
            long secondTeamGoals = long.Parse(match.Groups[2].ToString());
            long firstTeamPoints = 0;
            long secondTeamPoints = 0;

            if (firstTeamGoals > secondTeamGoals)
            {
                firstTeamPoints = 3;
                secondTeamPoints = 0;
            }
            else if (firstTeamGoals < secondTeamGoals)
            {
                firstTeamPoints = 0;
                secondTeamPoints = 3;
            }
            else
            {
                firstTeamPoints = 1;
                secondTeamPoints = 1;
            }

            if (!countriesAndGoals.ContainsKey(firstCountry) && !countriesAndPoints.ContainsKey(firstCountry))
            {
                countriesAndGoals.Add(firstCountry, 0);
                countriesAndPoints.Add(firstCountry, 0);
            }

            countriesAndGoals[firstCountry] += firstTeamGoals;
            countriesAndPoints[firstCountry] += firstTeamPoints;

            if (!countriesAndGoals.ContainsKey(secondCountry) && !countriesAndPoints.ContainsKey(secondCountry))
            {
                countriesAndGoals.Add(secondCountry, 0);
                countriesAndPoints.Add(secondCountry, 0);
            }

            countriesAndGoals[secondCountry] += secondTeamGoals;
            countriesAndPoints[secondCountry] += secondTeamPoints;

            input = Console.ReadLine();
        }

        Console.WriteLine("League standings:");
        int position = 1;
        
        foreach (var team in countriesAndPoints.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{position}. {team.Key} {team.Value}");
            position++;
        }

        Console.WriteLine("Top 3 scored goals:");
        int count = 3;

        foreach (var item in countriesAndGoals.OrderByDescending(g => g.Value).ThenBy(t => t.Key))
        {
            Console.WriteLine($"- {item.Key} -> {item.Value}");
            count--;

            if (count == 0)
            {
                break;
            }
        }
    }
}
