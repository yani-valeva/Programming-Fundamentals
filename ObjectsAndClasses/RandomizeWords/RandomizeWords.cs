using System;

public class RandomizeWords
{
    public static void Main()
    {
        string[] text = Console.ReadLine().Split(' ');

        Random rnd = new Random();

        for (int firstPosition = 0; firstPosition < text.Length; firstPosition++)
        {
            int secondPosition = rnd.Next(0, text.Length);
            string temp = text[firstPosition];
            text[firstPosition] = text[secondPosition];
            text[secondPosition] = temp;
        }

        Console.WriteLine(string.Join("\n", text));
    }
}
