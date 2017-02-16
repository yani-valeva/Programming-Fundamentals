using System;
using System.Text.RegularExpressions;

public class ExtractSentencesByKeyword
{
    public static void Main()
    {
        string word = Console.ReadLine();
        string[] text = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string pattern = $@".+\W{Regex.Escape(word)}\W.*";

        foreach (var sentence in text)
        {
            Regex regex = new Regex(pattern);
            bool isMatch = regex.IsMatch(sentence);
            
            if (isMatch)
            {
                Console.WriteLine(sentence.Trim());
            }
        }        
    }
}
