using System;
using System.Text.RegularExpressions;

public class WinningTicket
{
    public static void Main()
    {
        string[] input = Console.ReadLine()
                                .Split(new char[] { ',', ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        string pattern = @"@{6,}|#{6,}|\${6,}|\^{6,}";

        for (int i = 0; i < input.Length; i++)
        {
            string currentTicket = input[i];

            if (currentTicket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            string leftPart = currentTicket.Substring(0, 10);
            string rightPart = currentTicket.Substring(10);
            bool hasLeftMatch = HasMatch(leftPart, pattern);
            bool hasRightMatch = HasMatch(rightPart, pattern);

            if (!hasLeftMatch || !hasRightMatch)
            {
                Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                continue;
            }

            string leftMatch = FindMatch(leftPart, pattern);
            string rightMatch = FindMatch(rightPart, pattern);

            if (leftMatch[0] != rightMatch[0])
            {
                Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                continue;
            }
            if (leftMatch.Length == rightMatch.Length && leftMatch.Length == 10)
            {
                Console.WriteLine($"ticket \"{currentTicket}\" - 10{leftMatch[0]} Jackpot!");
                continue;
            }
            else
            {
                int min = Math.Min(leftMatch.Length, rightMatch.Length);
                Console.WriteLine($"ticket \"{currentTicket}\" - {min}{leftMatch[0]}");
                continue;
            }
        }
    }

    public static string FindMatch(string currentPart, string pattern)
    {
        Regex regex = new Regex(pattern);
        Match match = regex.Match(currentPart);
        return match.Value;
    }

    public static bool HasMatch(string currentPart, string pattern)
    {
        Regex regex = new Regex(pattern);
        bool hasMatch = regex.IsMatch(currentPart);
        return hasMatch;
    }
}
