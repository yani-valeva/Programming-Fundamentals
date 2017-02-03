using System;
using System.Linq;

public class ShortWordsSorted
{
    public static void Main()
    {
        var separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        string[] text = Console.ReadLine()
                            .ToLower()
                            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                            .Where(w => w.Length < 5)
                            .OrderBy(w => w)
                            .Distinct()
                            .ToArray();

        Console.WriteLine(string.Join(", ", text));
    }
}
