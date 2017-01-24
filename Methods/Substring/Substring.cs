using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char search = 'p';
        bool hasMatch = false;
        int newTextLength = text.Length;

        for (var i = 0; i < text.Length; i++)
        {
            if (text[i] == search)
            {
                hasMatch = true;

                int endIndex = jump + 1;

                if (endIndex > newTextLength)
                {
                    endIndex = newTextLength;
                }

                string matchedString = text.Substring(i, endIndex);

                Console.WriteLine(matchedString);

                i += jump;
                newTextLength -= endIndex;
            }
            else if (text[i] != search)
            {
                newTextLength -= 1;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}

