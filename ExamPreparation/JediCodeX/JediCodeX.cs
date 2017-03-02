using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class JediCodeX
{
    public static void Main()
    {
        //70/100
        int number = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        List<string> jediNames = new List<string>();
        List<string> jediMessages = new List<string>();

        for (int i = 0; i < number; i++)
        {
            string input = Console.ReadLine();
            sb.Append(input);
        }

        string firstPattern = Console.ReadLine();
        string secondPattern = Console.ReadLine();
        
        if(firstPattern == "" || secondPattern == "")
        {
            return;
        }

        string text = sb.ToString();
        int indexOfFirstPattern = text.IndexOf(firstPattern);

        while (indexOfFirstPattern >= 0)
        {
            string jediName = text.Substring(indexOfFirstPattern + firstPattern.Length, firstPattern.Length);
            bool isMatch = false;

            for (int i = 0; i < jediName.Length; i++)
            {
                if (!Char.IsLetter(jediName[i]))
                {
                    isMatch = false;
                    break;
                }
                else
                {
                    isMatch = true;
                }
            }
            if (isMatch)
            {
                jediNames.Add(jediName);
            }

            indexOfFirstPattern = text.IndexOf(firstPattern, indexOfFirstPattern + 1);
        }

        int indexOfSecondPattern = text.IndexOf(secondPattern);

        while (indexOfSecondPattern >= 0)
        {
            string jediMessage = text.Substring(indexOfSecondPattern + secondPattern.Length, secondPattern.Length);
            bool isMatch = false;

            for (int i = 0; i < jediMessage.Length; i++)
            {
                if (!Char.IsLetter(jediMessage[i]) && !Char.IsDigit(jediMessage[i]))
                {
                    isMatch = false;
                    break;
                }
                else if (Char.IsLetter(jediMessage[i]) || Char.IsDigit(jediMessage[i]))
                {
                    isMatch = true;
                }
            }
            if (isMatch)
            {
                jediMessages.Add(jediMessage);
            }

            indexOfSecondPattern = text.IndexOf(secondPattern, indexOfSecondPattern + 1);
        }

        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < jediNames.Count; i++)
        {
            string currentName = jediNames[i];
            int currentIndex = numbers[i];
            string currentMessage = string.Empty;
            bool isFound = false;

            if (currentIndex > 0 && currentIndex <= jediMessages.Count)
            {
                currentMessage = jediMessages[currentIndex - 1];
                isFound = true;
            }
            
            if (isFound)
            {
                Console.WriteLine($"{currentName} - {currentMessage}");
            }            
        }
    }
}
