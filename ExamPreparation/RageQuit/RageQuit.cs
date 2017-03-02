using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class RageQuit
{
    public static void Main()
    {
        string pattern = @"([^0-9]+)(\d+)";
        string input = Console.ReadLine();
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        StringBuilder sb = new StringBuilder();

        foreach (Match match in matches)
        {
            string word = match.Groups[1].ToString().ToUpper();
            int count = int.Parse(match.Groups[2].ToString());

            while (count > 0)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(word[i]);
                }

                count--;
            }            
        }

        string uniqueSymbols = new String(sb.ToString().Distinct().ToArray());

        Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");
        Console.WriteLine(sb.ToString());
    }
}
