using System;

public class CompareCharArrays
{
    public static void Main()
    {
        string[] firstWord = Console.ReadLine().Split(' ');
        string[] secondWord = Console.ReadLine().Split(' ');

        int minLength = Math.Min(firstWord.Length, secondWord.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (firstWord[i].CompareTo(secondWord[i]) > 0)
            {
                Console.WriteLine(string.Join("", secondWord));
                Console.WriteLine(string.Join("", firstWord));
                break;               
            }
            else if (firstWord[i].CompareTo(secondWord[i]) < 0)
            {
                Console.WriteLine(string.Join("", firstWord));
                Console.WriteLine(string.Join("", secondWord));
                break;
            }
            else if (firstWord[i].CompareTo(secondWord[i]) == 0)
            {
                if (i != minLength - 1)
                {
                    continue;
                }
                else
                {
                    if (firstWord.Length <= secondWord.Length)
                    {
                        Console.WriteLine(string.Join("", firstWord));
                        Console.WriteLine(string.Join("", secondWord));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", secondWord));
                        Console.WriteLine(string.Join("", firstWord));
                        break;
                    }
                }               
            }           
        }
    }
}
