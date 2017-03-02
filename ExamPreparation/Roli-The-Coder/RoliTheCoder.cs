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
            string[] inputInfo = input
                                  .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputInfo.Length < 2)
            {
                input = Console.ReadLine();
                continue;
            }

            int idNumber = 0;
            bool isParsed = int.TryParse(inputInfo[0], out idNumber);
            string eventName = inputInfo[1];

            if (!isParsed)
            {
                input = Console.ReadLine();
                continue;
            }
            if (!eventName.StartsWith("#"))
            {
                input = Console.ReadLine();
                continue;
            }

            eventName = eventName.TrimStart('#');
            bool isValidParticipant = true;
            List<string> participants = new List<string>();

            for (int i = 2; i < inputInfo.Length; i++)
            {
                string currentParticipant = inputInfo[i];

                if (!currentParticipant.StartsWith("@"))
                {
                    isValidParticipant = false;
                    break;
                }

                currentParticipant = currentParticipant.TrimStart('@');
                participants.Add(currentParticipant);
            }

            if (!isValidParticipant)
            {
                input = Console.ReadLine();
                continue;
            }

            if (!events.ContainsKey(idNumber))
            {
                events.Add(idNumber, new Dictionary<string, List<string>>());
                events[idNumber].Add(eventName, new List<string>());
            }
            if (events[idNumber].ContainsKey(eventName))
            {
                events[idNumber][eventName].AddRange(participants);
            }

            input = Console.ReadLine();
        }

        Dictionary<string, List<string>> selectedEvents = new Dictionary<string, List<string>>();

        foreach (var ev in events)
        {
            int id = ev.Key;
            var eventAndParticipantInfo = events[id].ToArray();
            string name = eventAndParticipantInfo[0].Key;
            var participantsInfo = eventAndParticipantInfo[0].Value;
            selectedEvents.Add(name, new List<string>());
            selectedEvents[name].AddRange(participantsInfo.Distinct());
        }

        foreach (var currentEvent in selectedEvents.OrderByDescending(p => p.Value.Count()).ThenBy(n => n.Key))
        {
            var currentEventName = currentEvent.Key;
            var currentParticipantsCount = currentEvent.Value.Count();
            var currentParticipants = selectedEvents[currentEvent.Key];

            Console.WriteLine($"{currentEventName} - {currentParticipantsCount}");

            foreach (var participant in currentParticipants.OrderBy(n => n))
            {
                Console.WriteLine($"@{participant}");
            }
        }
    }
}
