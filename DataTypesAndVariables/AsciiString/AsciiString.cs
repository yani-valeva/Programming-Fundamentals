using System;

public class AsciiString
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string result = string.Empty;

        for (int i = 0; i < number; i++)
        {
            int currentValue = int.Parse(Console.ReadLine());
            result += (char)currentValue;
        }

        Console.WriteLine(result);
    }
}
