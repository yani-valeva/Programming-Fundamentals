using System;

public class IndexOfLetters
{
    public static void Main()
    {
        char[] alphabet = new char[26];
        int index = 0;

        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            alphabet[index] = letter;
            index++;
        }

        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine($"{word[i]} -> {j}");
                }
            }
        }
    }
}
