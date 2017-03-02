using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class OlympicsAreComing
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, HashSet<string>> countryAndParticipants = new Dictionary<string, HashSet<string>>();
        Dictionary<string, int> countryAndTotalWins = new Dictionary<string, int>();

        while (!input.Equals("report"))
        {
            string[] inputInfo = input.Split('|');
            string participantName = inputInfo[0].Trim();
            string country = inputInfo[1].Trim();
            string pattern = @"\s{2,}";
            participantName = Regex.Replace(participantName, pattern, " ");
            country = Regex.Replace(country, pattern, " ");
            
            if (!countryAndParticipants.ContainsKey(country) && !countryAndTotalWins.ContainsKey(country))
            {
                countryAndParticipants.Add(country, new HashSet<string>());
                countryAndTotalWins.Add(country, 0);
            }

            countryAndParticipants[country].Add(participantName);
            countryAndTotalWins[country] += 1;

            input = Console.ReadLine();
        }

        foreach (var country in countryAndTotalWins.OrderByDescending(w => w.Value))
        {
            int participantNumber = countryAndParticipants[country.Key].Count;
            Console.WriteLine($"{country.Key} ({participantNumber} participants): {country.Value} wins");
        }
    }
}
