using System;
using System.Collections.Generic;
using System.Linq;

public class RoliTheCoder
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<int, Dictionary<string, List<string>>> events = new Dictionary<int, Dictionary<string, List<string>>>();

        while (!input.Equals("Time for Code"))
        {
            string[] inputInfo = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int id = int.Parse(inputInfo[0].Trim());
            if (inputInfo.Length < 2)
            {
                input = Console.ReadLine();
                continue;
            }
            if (!inputInfo[1][0].Equals('#'))
            {
                input = Console.ReadLine();
                continue;
            }

            string eventName = inputInfo[1].TrimStart('#');
            List<string> participants = new List<string>();

            for (int i = 2; i < inputInfo.Length; i++)
            {
                if (!inputInfo[i][0].Equals('@'))
                {
                    input = Console.ReadLine();
                    continue;
                }

                string participantName = inputInfo[i].TrimStart('@');
                participants.Add(participantName);
            }

            if (!events.ContainsKey(id))
            {
                events.Add(id, new Dictionary<string, List<string>>());

                if (!events[id].ContainsKey(eventName))
                {
                    events[id].Add(eventName, new List<string>());
                }
            }

            if (events.ContainsKey(id) && events[id].ContainsKey(eventName))
            {
                events[id][eventName].AddRange(participants);
            }

            input = Console.ReadLine();
        }

        Dictionary<string, List<string>> selectedEvents = new Dictionary<string, List<string>>();

        foreach (var item in events)
        {
            int idNumber = item.Key;
            var info = events[idNumber].Keys.ToArray();
            var name = info[0];
            var participantsInfo = events[idNumber].Values.ToArray();
            var participants = participantsInfo[0].Distinct();
            selectedEvents.Add(name, new List<string>());
            selectedEvents[name].AddRange(participants);
        }

        foreach (var item in selectedEvents.OrderByDescending(c => c.Value.Count).ThenBy(n => n.Key))
        {
            string name = item.Key;
            var orderedParticipants = selectedEvents[name].OrderBy(n => n);

            Console.WriteLine($"{name} - {item.Value.Count}");

            foreach (var participant in orderedParticipants)
            {
                Console.WriteLine($"@{participant}");
            }
        }
    }
}

