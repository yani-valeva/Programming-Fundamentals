using System;

public class CharacterMultiplier
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        bool areEqual = false;
        string first = string.Empty;
        string second = string.Empty;       

        if (input[0].Length < input[1].Length)
        {
            first = input[0];
            second = input[1];
        }
        else if (input[0].Length > input[1].Length)
        {
            first = input[1];
            second = input[0];
        }
        else
        {
            first = input[0];
            second = input[1];
            areEqual = true;
        }

        int minLength = Math.Min(input[0].Length, input[1].Length);
        long sum = 0;

        for (int i = 0; i < minLength; i++)
        {
            sum += first[i] * second[i];
        }

        if (!areEqual)
        {
            int difference = second.Length - first.Length;

            for (int i = minLength; i < minLength + difference; i++)
            {
                sum += second[i];
            }
        }

        Console.WriteLine(sum);
    }
}
