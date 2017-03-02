using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniKaraoke
{
    public static void Main()
    {
        string[] participantsInfo = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        string[] songsInfo = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        string input = Console.ReadLine();
        Dictionary<string, HashSet<string>> participants = new Dictionary<string, HashSet<string>>();

        while (!input.Equals("dawn"))
        {
            string[] performanceInfo = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string participantName = performanceInfo[0];
            string song = performanceInfo[1].Trim();
            string award = performanceInfo[2].Trim();
            bool isParticipant = false;
            bool containsSong = false;

            for (int i = 0; i < participantsInfo.Length; i++)
            {
                if (participantName == participantsInfo[i])
                {
                    isParticipant = true;
                    break;
                }
            }

            for (int i = 0; i < songsInfo.Length; i++)
            {
                if (song == songsInfo[i].Trim())
                {
                    containsSong = true;
                    break;
                }
            }

            if (isParticipant && containsSong)
            {
                if (!participants.ContainsKey(participantName))
                {
                    participants.Add(participantName, new HashSet<string>());
                }

                participants[participantName].Add(award);
            }

            input = Console.ReadLine();
        }

        bool areAvailable = false;

        foreach (var participant in participants.OrderByDescending(a => a.Value.Count).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

            var sortedAwards = participant.Value.OrderBy(a => a);

            foreach (var item in sortedAwards)
            {
                Console.WriteLine($"--{item}");
                areAvailable = true;
            }
        }

        if (!areAvailable)
        {
            Console.WriteLine("No awards");
        }
    }
}
