using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ArrangeIntegers
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
                               .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
        SortedDictionary<string, int> numbersAndTheirName = new SortedDictionary<string, int>();
        SortedDictionary<string, int> numbersAndCounts = new SortedDictionary<string, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            StringBuilder sb = new StringBuilder();

            if (currentNumber == 0)
            {
                sb.Insert(0, "-zero");
            }
            else
            {
                while (currentNumber > 0)
                {
                    int digit = currentNumber % 10;

                    switch (digit)
                    {
                        case 0:
                            sb.Insert(0, "-zero");
                            break;
                        case 1:
                            sb.Insert(0, "-one");
                            break;
                        case 2:
                            sb.Insert(0, "-two");
                            break;
                        case 3:
                            sb.Insert(0, "-three");
                            break;
                        case 4:
                            sb.Insert(0, "-four");
                            break;
                        case 5:
                            sb.Insert(0, "-five");
                            break;
                        case 6:
                            sb.Insert(0, "-six");
                            break;
                        case 7:
                            sb.Insert(0, "-seven");
                            break;
                        case 8:
                            sb.Insert(0, "-eight");
                            break;
                        case 9:
                            sb.Insert(0, "-nine");
                            break;
                    }

                    currentNumber = currentNumber / 10;
                }
            }

            sb.Remove(0, 1);

            if (!numbersAndTheirName.ContainsKey(sb.ToString()) && !numbersAndCounts.ContainsKey(sb.ToString()))
            {
                numbersAndTheirName.Add(sb.ToString(), numbers[i]);
                numbersAndCounts.Add(sb.ToString(), 0);
            }

            numbersAndCounts[sb.ToString()] += 1;
        }

        int[] orderedNumbers = new int[numbers.Length];
        int index = 0;

        foreach (var number in numbersAndTheirName)
        {
            while (numbersAndCounts[number.Key] > 0)
            {
                orderedNumbers[index] = number.Value;
                index++;
                numbersAndCounts[number.Key]--;
            }
            
        }

        Console.WriteLine(string.Join(", ", orderedNumbers));
    }
}
