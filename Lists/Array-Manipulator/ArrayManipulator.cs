using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayManipulator
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        string[] commands = Console.ReadLine().Split(' ');

        while (!commands[0].Equals("print"))
        {
            ExecuteCommands(numbers, commands);
            commands = Console.ReadLine().Split(' ');
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }

    public static void ExecuteCommands(List<int> numbers, string[] commands)
    {
        if (commands[0].Equals("add"))
        {
            int index = int.Parse(commands[1]);
            int number = int.Parse(commands[2]);
            numbers.Insert(index, number);
        }
        else if (commands[0].Equals("addMany"))
        {
            int index = int.Parse(commands[1]);

            for (int i = 2; i < commands.Length; i++)
            {
                int currentNumber = int.Parse(commands[i]);
                numbers.Insert(index, currentNumber);
                index++;
            }
        }
        else if (commands[0].Contains("contains"))
        {
            int element = int.Parse(commands[1]);
            bool isFound = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == element)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("-1");
            }
        }
        else if (commands[0].Equals("remove"))
        {
            int index = int.Parse(commands[1]);
            numbers.RemoveAt(index);
        }
        else if (commands[0].Equals("shift"))
        {
            int position = int.Parse(commands[1]);

            for (int i = 0; i < position % numbers.Count; i++)
            {
                int firstNumber = numbers[0];

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Count - 1] = firstNumber;
            }
        }
        else if (commands[0].Equals("sumPairs"))
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
            }
        }
    }
}
