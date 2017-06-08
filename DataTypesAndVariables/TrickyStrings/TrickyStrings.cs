using System;
using System.Text;

public class TrickyStrings
{
    public static void Main()
    {
        string delimiter = Console.ReadLine();
        int number = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < number; i++)
        {
            String currentLine = Console.ReadLine();

            if (i == number - 1)
            {
                sb.Append(currentLine);
            }
            else
            {
                sb.Append(currentLine + delimiter);
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
