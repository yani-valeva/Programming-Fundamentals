using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        bool hasType = false;
        bool hasSource = false;
        bool hasForecast = false;
        string type = "";
        string source = "";
        string forecast = "";
        string firstPattern = @"^Source: [a-zA-Z0-9]+$";
        string secondPattern = @"^Forecast: [^!\.,?]+$";

        Regex regex = new Regex(firstPattern);
        Regex reg = new Regex(secondPattern);

        while (!line.Equals("Davai Emo"))
        {
            if (!hasType)
            {
                string[] currentLine = line.Split();
                if (currentLine.Length == 2 && currentLine[0] == "Type:" && (currentLine[1] == "Normal" || currentLine[1] == "Warning" || currentLine[1] == "Danger"))
                {
                    hasType = true;
                    type = currentLine[1];
                }
            }
            else if (!hasSource)
            {
               hasSource = regex.IsMatch(line);
                if (hasSource)
                {
                    source = line.Substring(8);
                }

            }
            else if (!hasForecast)
            {
                hasForecast = reg.IsMatch(line);
                if (hasForecast)
                {
                    forecast = line.Substring(10);
                    Console.WriteLine($"({type}) {forecast} ~ {source}");
                    hasType = false;
                    hasSource = false;
                    hasForecast = false;
                }
            }

            line = Console.ReadLine();
        }
    }
}