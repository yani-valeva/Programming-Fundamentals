using System;

public class DNASequences
{
    public static void Main()
    {
        int matchSum = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    int currentSum = i + j + k;
                    string startEnd = currentSum >= matchSum ? "O" : "X";
                    string firstNucleotid = GetNucleotid(i);
                    string secondNucleotid = GetNucleotid(j);
                    string thirdNucleotid = GetNucleotid(k);

                    Console.Write($"{startEnd}{firstNucleotid}{secondNucleotid}{thirdNucleotid}{startEnd} ");
                }

                Console.WriteLine();
            }
        }
    }

    private static string GetNucleotid(int number)
    {
        string currentNucleotid = "";
        switch (number)
        {
            case 1:
                currentNucleotid = "A";
                break;
            case 2:
                currentNucleotid = "C";
                break;
            case 3:
                currentNucleotid = "G";
                break;
            case 4:
                currentNucleotid = "T";
                break;
            default:
                currentNucleotid = "0";
                break;
        }

        return currentNucleotid;
    }
}
