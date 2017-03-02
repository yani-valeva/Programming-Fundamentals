using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayModifier
{
    public static void Main()
    {
        List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
        string input = Console.ReadLine();

        while (!input.Equals("end"))
        {
            string[] commandInfo = input.Split(' ');

            if (commandInfo[0] == "swap")
            {
                int firstIndex = int.Parse(commandInfo[1]);
                int secondIndex = int.Parse(commandInfo[2]);
                long temporary = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temporary;
            }
            else if (commandInfo[0] == "multiply")
            {
                int firstIndex = int.Parse(commandInfo[1]);
                int secondIndex = int.Parse(commandInfo[2]);
                long multiply = numbers[firstIndex] * numbers[secondIndex];
                numbers[firstIndex] = multiply;
            }
            else if (commandInfo[0] == "decrease")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] -= 1;
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}
