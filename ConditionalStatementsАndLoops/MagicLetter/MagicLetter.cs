using System;

public class MagicLetter
{
    public static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        char thirdLetter = char.Parse(Console.ReadLine());

        for (char letter1 = firstLetter; letter1 <= secondLetter; letter1++)
        {
            for (char letter2 = firstLetter; letter2 <= secondLetter; letter2++)
            {
                for (char letter3 = firstLetter; letter3 <= secondLetter; letter3++)
                {
                    if (letter1 == thirdLetter || letter2 == thirdLetter || letter3 == thirdLetter)
                    {
                        continue;
                    }

                    Console.Write($"{letter1}{letter2}{letter3} ");
                }
            }
        }

        Console.WriteLine();
    }
}
