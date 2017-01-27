using System;

public class LargestCommonEnd
{
    public static void Main()
    {
        string[] firstText = Console.ReadLine().Split(' ');
        string[] secondText = Console.ReadLine().Split(' ');

        int countFromLeftToRight = 0;
        int minLength = Math.Min(firstText.Length, secondText.Length);
       
        for (int i = 0; i < minLength; i++)
        {
            if (firstText[i].Equals(secondText[i]))
            {
                countFromLeftToRight++;
            }
            else
            {
                break;
            }
        }

        int countFromRightToLeft = 0;
        Array.Reverse(firstText);
        Array.Reverse(secondText);
        
        for (int i = 0; i < minLength; i++)
        {
            if (firstText[i].Equals(secondText[i]))
            {
                countFromRightToLeft++;
            }
            else
            {
                break;
            }
        }

        int maxCount = Math.Max(countFromLeftToRight, countFromRightToLeft);

        Console.WriteLine(maxCount);
    }
}
