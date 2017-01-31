using System;
using System.Collections.Generic;
using System.Linq;

public class SplitByWordCasing
{
    public static void Main()
    {
        var separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
        List<string> text = Console.ReadLine()
                            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

        List<string> lowerCaseWords = new List<string>();
        List<string> mixedCaseWords = new List<string>();
        List<string> upperCaseWords = new List<string>();

        foreach (var word in text)
        {
            if (word.All(char.IsUpper))
            {
                upperCaseWords.Add(word);
            }
            else if (word.All(char.IsLower))
            {
                lowerCaseWords.Add(word);
            }
            else
            {
                mixedCaseWords.Add(word);
            }
        }

        Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
    }
}
