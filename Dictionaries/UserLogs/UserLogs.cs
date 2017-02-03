using System;
using System.Collections.Generic;

public class UserLogs
{
    public static void Main()
    {
        string input = Console.ReadLine();
        SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();

        while (!input.Equals("end"))
        {
            string[] usersInfo = input.Split(' ');
            string[] usersNameInfo = usersInfo[usersInfo.Length - 1].Split('=');
            string userName = usersNameInfo[1];
            string[] ipInfo = usersInfo[0].Split('=');
            string userIp = ipInfo[1];

            if (!userLogs.ContainsKey(userName))
            {
                userLogs.Add(userName, new Dictionary<string, int>());
            }
            if (!userLogs[userName].ContainsKey(userIp))
            {
                userLogs[userName].Add(userIp, 0);
            }

            userLogs[userName][userIp] += 1;

            input = Console.ReadLine();
        }

        foreach (var key in userLogs)
        {
            string name = key.Key;

            Console.WriteLine($"{name}: ");

            int count = 0;

            foreach (var ip in userLogs[name])
            {
                int numbersOfIp = userLogs[name].Count;
                count++;

                if (count == numbersOfIp)
                {
                    Console.WriteLine($"{ip.Key} => {ip.Value}.");
                }
                else
                {
                    Console.Write($"{ip.Key} => {ip.Value}, ");
                }                
            }
        }
    }
}
