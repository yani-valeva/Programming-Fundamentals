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
            switch (commands[0])
            {
                case "add":
                    AddElement(numbers, commands);
                    break;
                case "addMany":
                    AddManyElements(numbers, commands);
                    break;
                case "contains":
                    ContainsElement(numbers, commands);
                    break;
                case "remove":
                    RemoveIndex(numbers, commands);
                    break;
                case "shift":
                    ShiftElements(numbers, commands);
                    break;
                case "sumPairs":
                    SumPairs(numbers, commands);
                    break;
            }

            commands = Console.ReadLine().Split(' ');
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }

    public static void SumPairs(List<int> numbers, string[] commands)
    {
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            numbers[i] += numbers[i + 1];
            numbers.RemoveAt(i + 1);
        }
    }

    public static void ShiftElements(List<int> numbers, string[] commands)
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

    public static void RemoveIndex(List<int> numbers, string[] commands)
    {
        int index = int.Parse(commands[1]);
        numbers.RemoveAt(index);
    }

    public static void ContainsElement(List<int> numbers, string[] commands)
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

    public static void AddManyElements(List<int> numbers, string[] commands)
    {
        int index = int.Parse(commands[1]);

        for (int i = 2; i < commands.Length; i++)
        {
            int currentNumber = int.Parse(commands[i]);
            numbers.Insert(index, currentNumber);
            index++;
        }
    }

    public static void AddElement(List<int> numbers, string[] commands)
    {
        int index = int.Parse(commands[1]);
        int number = int.Parse(commands[2]);
        numbers.Insert(index, number);
    }  
}
