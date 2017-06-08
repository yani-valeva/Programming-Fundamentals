using System;
using System.Text;

public class CypherRoulette
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        int spinCount = 0;
        string previousLine = string.Empty;

        for (int i = 0; i < number; i++)
        {
            string currentLine = Console.ReadLine();

            if (currentLine.Equals(previousLine))
            {
                sb.Clear();
                previousLine = currentLine;

                if (previousLine.Equals("spin"))
                {
                    number++;
                }

                continue;
            }

            if (currentLine.Equals("spin"))
            {
                spinCount++;
                number++;
                previousLine = currentLine;
                continue;
            }

            if (spinCount % 2 != 0)
            {
                sb.Insert(0, currentLine);
                previousLine = currentLine;
                continue;
            }

            sb.Append(currentLine);
            previousLine = currentLine;
        }

        Console.WriteLine(sb.ToString());
    }
}
