using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

public class Events
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, List<DateTime>>> events = new Dictionary<string, Dictionary<string, List<DateTime>>>();
        int numberOfEvents = int.Parse(Console.ReadLine());
        string pattern = @"^#([a-zA-Z]+):\s*@([a-zA-Z]+)\s*((\d{2}):(\d{2}))$";

        for (int i = 0; i < numberOfEvents; i++)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            bool isMatch = regex.IsMatch(input);

            if (!isMatch)
            {
                continue;
            }

            MatchCollection matches = regex.Matches(input);
            string name = string.Empty;
            string place = string.Empty;
            string timeAsString = string.Empty;

            foreach (Match match in matches)
            {
                name = match.Groups[1].Value;
                place = match.Groups[2].Value;
                int hours = int.Parse(match.Groups[4].Value);
                int minutes = int.Parse(match.Groups[5].Value);

                if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59)
                {
                    isMatch = false;
                    break;
                }

                timeAsString = match.Groups[3].Value;
            }

            if (!isMatch)
            {
                continue;
            } 

            DateTime time = DateTime.ParseExact(timeAsString, "HH:mm", CultureInfo.InvariantCulture);
           
            if (!events.ContainsKey(place))
            {
                events.Add(place, new Dictionary<string, List<DateTime>>());
            }
            if (!events[place].ContainsKey(name))
            {
                events[place].Add(name, new List<DateTime>());
            }

            events[place][name].Add(time);
        }

        SortedDictionary<string, SortedDictionary<string, List<DateTime>>> filteredEvents = new SortedDictionary<string, SortedDictionary<string, List<DateTime>>>();
        string[] neededLocation = Console.ReadLine().Split(',');

        for (int i = 0; i < neededLocation.Length; i++)
        {
            string currentLocation = neededLocation[i];

            if (!events.ContainsKey(currentLocation))
            {
                continue;
            }

            var selectedPeople = events[currentLocation];
            filteredEvents.Add(currentLocation, new SortedDictionary<string, List<DateTime>>());

            foreach (var item in selectedPeople)
            {
                filteredEvents[currentLocation].Add(item.Key, new List<DateTime>());
                filteredEvents[currentLocation][item.Key].AddRange(item.Value);
            }
        }

        foreach (var ev in filteredEvents)
        {
            Console.WriteLine($"{ev.Key}:");

            var selectedByPlace = filteredEvents[ev.Key];
            int number = 1;

            foreach (var currentName in selectedByPlace.OrderBy(n => n.Key))
            {
                var orderedDate = currentName.Value.OrderBy(v => v).ToList();
                int count = orderedDate.Count;
                Console.Write($"{number}. {currentName.Key} -> ");

                for (int i = 0; i < count; i++)
                {
                    if (i == count - 1)
                    {
                        Console.WriteLine($"{orderedDate[i].ToString("HH:mm")}");
                    }
                    else
                    {
                        Console.Write($"{orderedDate[i].ToString("HH:mm")}, ");
                        
                    }
                    
                }               
                number++;
            }
        }
    }
}
