using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ValidUsernames
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        string pattern = @"\b[a-zA-Z]\w{2,24}\b";
        List<string> selectedUserNames = new List<string>();

        foreach (var item in input)
        {
            Regex regex = new Regex(pattern);
            bool isMatch = regex.IsMatch(item);

            if (isMatch)
            {
                selectedUserNames.Add(item);
            }
        }

        int sum = 0;
        int biggestSum = 0;
        int start = 0;

        for (int i = 0; i < selectedUserNames.Count - 1; i++)
        {
            int firstUserNameLength = selectedUserNames[i].Length;
            int secondUserNameLength = selectedUserNames[i + 1].Length;
            sum = firstUserNameLength + secondUserNameLength;

            if (biggestSum < sum)
            {
                biggestSum = sum;
                start = i;
            }

            sum = 0;
        }

        Console.WriteLine(selectedUserNames[start]);
        Console.WriteLine(selectedUserNames[start + 1]);
    }
}
