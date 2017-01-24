using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                if (!input[j].Equals(string.Empty))
                {
                    int num = int.Parse(input[j]);
                    numbers.Add(num);
                }
            }

            bool isFound = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    if (isFound)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);

                    isFound = true;
                }
                else
                {
                    if (j == numbers.Count - 1)
                    {
                        continue;
                    }
                    else
                    {
                        currentNum += numbers[j + 1];

                        if (currentNum >= 0)
                        {
                            if (isFound)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            isFound = true;
                        }
                        j++;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}

