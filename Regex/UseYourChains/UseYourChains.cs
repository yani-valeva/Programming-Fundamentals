using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class UseYourChains
{
    public static void Main()
    {
        string firstPattern = @"<p>(.+?)<\/p>";
        string text = Console.ReadLine();

        Regex regex = new Regex(firstPattern);
        MatchCollection matches = regex.Matches(text);

        List<string> matchCollection = new List<string>();
        foreach (Match match in matches)
        {
            matchCollection.Add(match.Groups[1].ToString());
        }

        StringBuilder sb = new StringBuilder();
        string replacement = " ";

        for (int i = 0; i < matchCollection.Count; i++)
        {
            string secondPattern = @"[^a-z0-9]";
            
            string currentText = matchCollection[i];
            Regex reg = new Regex(secondPattern);
            matchCollection[i] = reg.Replace(currentText, replacement);           
            sb.Append(matchCollection[i]);
        }

        ConvertSmallLetters(sb);

        string thirdPattern = @"\s+";
        StringBuilder decryptedText = new StringBuilder(Regex.Replace(sb.ToString(), thirdPattern, replacement));

        Console.WriteLine(decryptedText.ToString().Trim());
    }

    public static void ConvertSmallLetters(StringBuilder sb)
    {
        for (int i = 0; i < sb.Length; i++)
        {
            var currentCharacter = sb[i];

            switch (currentCharacter)
            {
                case 'a':
                    sb[i] = 'n';
                    break;
                case 'b':
                    sb[i] = 'o';
                    break;
                case 'c':
                    sb[i] = 'p';
                    break;
                case 'd':
                    sb[i] = 'q';
                    break;
                case 'e':
                    sb[i] = 'r';
                    break;
                case 'f':
                    sb[i] = 's';
                    break;
                case 'g':
                    sb[i] = 't';
                    break;
                case 'h':
                    sb[i] = 'u';
                    break;
                case 'i':
                    sb[i] = 'v';
                    break;
                case 'j':
                    sb[i] = 'w';
                    break;
                case 'k':
                    sb[i] = 'x';
                    break;
                case 'l':
                    sb[i] = 'y';
                    break;
                case 'm':
                    sb[i] = 'z';
                    break;
                case 'n':
                    sb[i] = 'a';
                    break;
                case 'o':
                    sb[i] = 'b';
                    break;
                case 'p':
                    sb[i] = 'c';
                    break;
                case 'q':
                    sb[i] = 'd';
                    break;
                case 'r':
                    sb[i] = 'e';
                    break;
                case 's':
                    sb[i] = 'f';
                    break;
                case 't':
                    sb[i] = 'g';
                    break;
                case 'u':
                    sb[i] = 'h';
                    break;
                case 'v':
                    sb[i] = 'i';
                    break;
                case 'w':
                    sb[i] = 'j';
                    break;
                case 'x':
                    sb[i] = 'k';
                    break;
                case 'y':
                    sb[i] = 'l';
                    break;
                case 'z':
                    sb[i] = 'm';
                    break;                
            }
        }
    }
}
