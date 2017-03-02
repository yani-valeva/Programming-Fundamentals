using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class HornetComm
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string firstPattern = @"^(\d+)\s<->\s([a-zA-Z0-9]+)$";
        string secondPattern = @"^([^0-9]+)\s<->\s([a-zA-Z0-9]+)$";
        Dictionary<string, string> messages = new Dictionary<string, string>();
        Dictionary<string, string> broadcasts = new Dictionary<string, string>();
        List<string> allMessages = new List<string>();
        List<string> allBroadcasts = new List<string>();
        Regex regex = new Regex(firstPattern);
        Regex reg = new Regex(secondPattern);

        while (!input.Equals("Hornet is Green"))
        {
            bool isMassage = regex.IsMatch(input);
            bool isBroadcast = reg.IsMatch(input);

            if (isMassage)
            {
                Match match = regex.Match(input);

                string codeAsString = match.Groups[1].Value;
                string currentMassage = match.Groups[2].Value;
                StringBuilder sb = new StringBuilder();

                for (int i = codeAsString.Length - 1; i >= 0; i--)
                {
                    sb.Append(codeAsString[i]);
                }
                codeAsString = sb.ToString();

                if (!messages.ContainsKey(currentMassage))
                {
                    messages.Add(currentMassage, null);
                }

                messages[currentMassage] = codeAsString;
                allMessages.Add(currentMassage);
            }
            else if (isBroadcast)
            {
                Match match = reg.Match(input);

                string message = match.Groups[1].Value;
                string frequencyAsString = match.Groups[2].Value;
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < frequencyAsString.Length; i++)
                {
                    var currentSymbol = frequencyAsString[i];
                    var symbol = string.Empty;
                    if (Char.IsLetter(currentSymbol))
                    {
                        if (Char.IsUpper(currentSymbol))
                        {
                            symbol = currentSymbol.ToString().ToLower();
                        }
                        else
                        {
                            symbol = currentSymbol.ToString().ToUpper();
                        }

                        builder.Append(symbol);
                    }
                    else
                    {
                        builder.Append(currentSymbol);
                    }
                }

                frequencyAsString = builder.ToString();

                if (!broadcasts.ContainsKey(message))
                {
                    broadcasts.Add(message, null);
                }

                broadcasts[message] = frequencyAsString;
                allBroadcasts.Add(message);
            }

            input = Console.ReadLine();
        }

        Console.WriteLine("Broadcasts:");
        bool isFoundBroadcast = false;

        foreach (var item in allBroadcasts)
        {
            var currentItem = item;
            var keyResult = broadcasts[item];
            Console.WriteLine($"{keyResult} -> {item}");
            isFoundBroadcast = true;
        }

        if (!isFoundBroadcast)
        {
            Console.WriteLine("None");
        }

        Console.WriteLine("Messages:");
        bool isFoundMassages = false;

        foreach (var item in allMessages)
        {
            var currentItem = item;
            var keyResult = messages[item];
            Console.WriteLine($"{keyResult} -> {item}");
            isFoundMassages = true;
        }

        if (!isFoundMassages)
        {
            Console.WriteLine("None");
        }
    }
}

