using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class SerbianUnleashed
{
    public static void Main()
    {
        string pattern = @"(([a-zA-Z]+\s)+)@(([a-zA-Z]+\s)+)(\d+)\s(\d+)";
        string input = Console.ReadLine();
        Dictionary<string, Dictionary<string, long>> concertsInfo = new Dictionary<string, Dictionary<string, long>>();

        while (!input.Equals("End"))
        {
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string singerName = match.Groups[1].Value.Trim();
                string venue = match.Groups[3].Value.Trim();
                long ticketsPrice = long.Parse(match.Groups[5].Value);
                long ticketsCount = long.Parse(match.Groups[6].Value);

                if (!concertsInfo.ContainsKey(venue))
                {
                    concertsInfo.Add(venue, new Dictionary<string, long>());
                }
                if (!concertsInfo[venue].ContainsKey(singerName))
                {
                    concertsInfo[venue].Add(singerName, 0L);
                }

                concertsInfo[venue][singerName] += ticketsPrice * ticketsCount;
            }

            input = Console.ReadLine();
        }

        foreach (var concert in concertsInfo)
        {
            Console.WriteLine($"{concert.Key}");

            var singersInfo = concertsInfo[concert.Key];

            foreach (var singer in singersInfo.OrderByDescending(m => m.Value))
            {
                Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
            }
        }
    }
}
