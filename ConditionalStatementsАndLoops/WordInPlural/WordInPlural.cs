using System;

public class WordInPlural
{
    public static void Main()
    {
        string word = Console.ReadLine().ToLower();
        
        if (word.EndsWith("y"))
        {
            word = word.Remove(word.Length - 1);
            Console.WriteLine($"{word}ies");
        }
        else if (word.EndsWith("o") || word.EndsWith("ch") ||
            word.EndsWith("s") || word.EndsWith("sh") || 
            word.EndsWith("x") || word.EndsWith("z"))
        {
            Console.WriteLine($"{word}es");
        }
        else
        {
            Console.WriteLine($"{word}s");
        }
    }
}
