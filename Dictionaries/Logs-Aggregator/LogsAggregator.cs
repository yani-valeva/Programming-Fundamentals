using System;
using System.Collections.Generic;
using System.Linq;

public class LogsAggregator
{
    public static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        SortedDictionary<string, SortedDictionary<string, int>> userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();

        for (int i = 0; i < numbers; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string userIpAdress = input[0];
            string userName = input[1];
            int duration = int.Parse(input[2]);

            if (!userLogs.ContainsKey(userName))
            {
                userLogs.Add(userName, new SortedDictionary<string, int>());               
            }
            if (!userLogs[userName].ContainsKey(userIpAdress))
            {
                userLogs[userName].Add(userIpAdress, 0);
            }

            userLogs[userName][userIpAdress] += duration;            
        }

        foreach (var key in userLogs)
        {
            string name = key.Key;
            int totalDuration = key.Value.Values.Sum();
            var ips = key.Value.Keys.ToList();

            Console.WriteLine($"{name}: {totalDuration} [{string.Join(", ", ips)}]");
        }
    }
}