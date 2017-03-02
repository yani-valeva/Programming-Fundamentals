using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class CubicMessages
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(^\d+)([a-zA-Z]+)([^a-zA-Z]*$)";

        while (!input.Equals("Over!"))
        {
            int number = int.Parse(Console.ReadLine());
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            bool hasMatch = regex.IsMatch(input);

            if (!hasMatch)
            {
                input = Console.ReadLine();
                continue;
            }

            foreach (Match match in matches)
            {
                string numbersAsString = match.Groups[1].ToString();
                string text = match.Groups[2].ToString();
                string symbols = match.Groups[3].ToString();

                if (text.Length != number)
                {
                    break;
                }

                List<int> indexes = new List<int>();

                for (int i = 0; i < numbersAsString.Length; i++)
                {
                    indexes.Add(int.Parse(numbersAsString[i].ToString()));
                }

                for (int i = 0; i < symbols.Length; i++)
                {
                    char symbol = char.Parse(symbols[i].ToString());

                    if (Char.IsDigit(symbol))
                    {
                        int digit = (int)Char.GetNumericValue(symbol);
                        indexes.Add(digit);
                    }
                }

                Console.Write($"{text} == ");
                int index = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (index == indexes.Count)
                    {
                        break;
                    }
                    if (indexes[index] == i)
                    {
                        Console.Write(text[i]);
                        index++;
                        i = -1;
                    }
                    else if (indexes[index] >= text.Length)
                    {
                        Console.Write(" ");
                        index++;
                        i = -1;
                        continue;
                    }                   
                }

                Console.WriteLine();
            }

            input = Console.ReadLine();
        }      
    }
}
