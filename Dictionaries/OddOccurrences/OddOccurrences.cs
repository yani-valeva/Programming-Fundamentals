using System;
using System.Collections.Generic;
using System.Linq;

public class OddOccurrences
{
    public static void Main()
    {
        string[] text = Console.ReadLine().ToLower().Split(' ');
        Dictionary<string, int> wordsAppearance = new Dictionary<string, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (!wordsAppearance.ContainsKey(text[i]))
            {
                wordsAppearance.Add(text[i], 0);
            }

            wordsAppearance[text[i]] += 1;
        }

        List<string> result = new List<string>();

        foreach (var key in wordsAppearance)
        {
            if (key.Value % 2 != 0)
            {
                result.Add(key.Key);
            }
        }

        Console.WriteLine(string.Join(", ", result));
    }
}
