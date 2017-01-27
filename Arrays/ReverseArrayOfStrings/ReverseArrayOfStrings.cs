using System;
using System.Linq;

public class ReverseArrayOfStrings
{
    public static void Main()
    {
        string[] text = Console.ReadLine().Split(' ');
        string[] reversedText = text.Reverse().ToArray();

        Console.WriteLine(string.Join(" ", reversedText));
    }
}
