using System;
using System.Text.RegularExpressions;

public class ReplaceTag
{
    public static void Main()
    {
        string pattern = @"<a\s+.+?=("".+?"")>(.+?)<\/a>";
        string replacement = @"[URL href=$1]$2[/URL]";
        string text = Console.ReadLine();

        while (!text.Equals("end"))
        {
            Regex regex = new Regex(pattern);
            string result = regex.Replace(text, replacement);

            Console.WriteLine(result);

            text = Console.ReadLine();
        }       
    }
}
