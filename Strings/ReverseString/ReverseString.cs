using System;

public class ReverseString
{
    public static void Main()
    {
        string input = Console.ReadLine();
        char[] word = input.ToCharArray();
        Array.Reverse(word);

        Console.WriteLine(string.Join("", word));
    }
}
