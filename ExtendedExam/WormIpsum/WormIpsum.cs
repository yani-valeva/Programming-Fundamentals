using System;
using System.Text;

public class WormIpsum
{
    public static void Main()
    {
        string text = Console.ReadLine();

        while (!text.Equals("Worm Ipsum"))
        {
            int index = text.IndexOf('.');
            if (index == -1 || !Char.IsUpper(text[0]))
            {
                text = Console.ReadLine();
                continue;
            }
            int nextIndex = text.IndexOf('.', index + 1);
            if (nextIndex != -1)
            {
                text = Console.ReadLine();
                continue;
            }
            text = text.TrimEnd('.');
            string[] words = text.Split();
            char letter = '\0';

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                bool hasComma = false;
                if (currentWord[currentWord.Length - 1] == ',')
                {
                    hasComma = true;
                }
                currentWord = currentWord.TrimEnd(',');
                int maxCount = int.MinValue;

                for (int j = 0; j < currentWord.Length - 1; j++)
                {
                    int count = 0;
                    for (int k = j + 1; k < currentWord.Length; k++)
                    {
                        if (currentWord[j] == currentWord[k])
                        {
                            count++;
                        }
                    }

                    if (count != 0 && maxCount < count)
                    {
                        maxCount = count;
                        letter = currentWord[j];
                    }
                }


                if (maxCount != int.MinValue)
                {
                    StringBuilder sb = new StringBuilder();

                    for (int m = 0; m < currentWord.Length; m++)
                    {
                        sb.Append(letter);
                    }

                    text = text.Replace(currentWord, sb.ToString());
                }                
            }

            Console.WriteLine("{0}.", text);

            text = Console.ReadLine();
        }
    }
}
