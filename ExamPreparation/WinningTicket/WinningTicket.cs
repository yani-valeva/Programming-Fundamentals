using System;
using System.Text;
using System.Text.RegularExpressions;

public class WinningTicket
{
    public static void Main()
    {
        string pattern = @"@{6,10}|#{6,10}|\${6,10}|\^{6,10}";
        string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < input.Length; i++)
        {
            string currentTicket = input[i];

            if  (currentTicket.Length == 20)
            {
                StringBuilder ticketLeftPart = new StringBuilder();
                StringBuilder ticketRightPart = new StringBuilder();

                for (int j = 0; j < currentTicket.Length / 2; j++)
                {
                    ticketLeftPart.Append(currentTicket[j]);
                }

                for (int k = currentTicket.Length / 2; k < currentTicket.Length; k++)
                {
                    ticketRightPart.Append(currentTicket[k]);
                }

                Regex regex = new Regex(pattern);

                bool hasMatchLeftPart = regex.IsMatch(ticketLeftPart.ToString());
                bool hasMatchRightPart = regex.IsMatch(ticketRightPart.ToString());

                if (hasMatchLeftPart && hasMatchRightPart)
                {
                    Match left = regex.Match(ticketLeftPart.ToString());
                    string leftMatch = left.Groups[0].ToString();
                    Match right = regex.Match(ticketRightPart.ToString());
                    string rightMatch = right.Groups[0].ToString();

                    if (leftMatch[0] == rightMatch[0] && leftMatch.Length == rightMatch.Length && leftMatch.Length < 10)
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - {leftMatch.Length}{leftMatch[0]}");
                    }
                    else if (leftMatch[0] == rightMatch[0] && leftMatch.Length != rightMatch.Length)
                    {
                        int minLength = Math.Min(leftMatch.Length, rightMatch.Length);
                        Console.WriteLine($"ticket \"{currentTicket}\" - {minLength}{leftMatch[0]}");                       
                    }
                    else if (leftMatch[0] == rightMatch[0] && leftMatch.Length == rightMatch.Length && leftMatch.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - 10{leftMatch[0]} Jackpot!");
                    }          
                    else
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                }
            }
            else
            {
                Console.WriteLine("invalid ticket");
            }
        }
    }
}
