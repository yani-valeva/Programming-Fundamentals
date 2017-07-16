using System;
using System.Text;
using System.Text.RegularExpressions;

public class Regexmon
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string bojoPattern = @"[a-zA-Z]+-[a-zA-Z]+";
        string didiPattern = @"[^a-zA-Z-]+";
        StringBuilder sb = new StringBuilder();
        sb.Append(input);
        Regex regex = new Regex(bojoPattern);
        Regex reg = new Regex(didiPattern);
        int count = 1;

        while (sb.Length > 0)
        {
            bool isFound = false;
            if (count % 2 != 0)
            {
                isFound = reg.IsMatch(sb.ToString());

            }
            else
            {
                isFound = regex.IsMatch(sb.ToString());
                Match match = regex.Match(sb.ToString());
            }

            if (isFound)
            {
                if (count % 2 != 0)
                {
                    Match match = reg.Match(sb.ToString());
                    Console.WriteLine(match.Groups[0]);
                    int index = sb.ToString().IndexOf(match.Groups[0].ToString(), 0);
                    sb.Remove(0, match.Groups[0].ToString().Length + index);
                }
                else
                {
                    Match match = regex.Match(sb.ToString());
                    Console.WriteLine(match.Groups[0]);
                    int index = sb.ToString().IndexOf(match.Groups[0].ToString(), 0);
                    sb.Remove(0, match.Groups[0].ToString().Length + index);
                }
            }
            else
            {
                return;
            }

            count++;
        }
    }
}
