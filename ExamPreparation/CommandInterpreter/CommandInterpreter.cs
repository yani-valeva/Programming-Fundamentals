using System;
using System.Collections.Generic;
using System.Linq;

public class CommandInterpreter
{
    public static void Main()
    {
        List<string> numbers = Console.ReadLine()
                                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        string input = Console.ReadLine();

        while (!input.Equals("end"))
        {
            string[] commandInfo = input.Split(' ');
            string command = commandInfo[0];

            if (command == "reverse")
            {
                int start = int.Parse(commandInfo[2]);
                int count = int.Parse(commandInfo[4]);

                if (start < 0 || start >= numbers.Count)
                {
                    Console.WriteLine("Invalid input parameters.");
                    input = Console.ReadLine();
                    continue;
                }

                long endCommandIndex = (long)start + count;

                if (count < 0 ||  endCommandIndex > numbers.Count)
                {
                    Console.WriteLine("Invalid input parameters.");
                    input = Console.ReadLine();
                    continue;
                }

                var reversedElements = numbers.Skip(start).Take(count).Reverse().ToList();
                numbers.RemoveRange(start, count);
                numbers.InsertRange(start, reversedElements);               
            }
            else if (command == "sort")
            {
                int start = int.Parse(commandInfo[2]);
                int count = int.Parse(commandInfo[4]);

                if (start < 0 || start >= numbers.Count)
                {
                    Console.WriteLine("Invalid input parameters.");
                    input = Console.ReadLine();
                    continue;
                }

                long endCommandIndex = (long)start + count;

                if (count < 0 || endCommandIndex > numbers.Count)
                {
                    Console.WriteLine("Invalid input parameters.");
                    input = Console.ReadLine();
                    continue;
                }

                var sortedElements = numbers.Skip(start).Take(count).ToList();
                sortedElements.Sort();
                numbers.RemoveRange(start, count);
                numbers.InsertRange(start, sortedElements);
            }
            else if (command == "rollLeft")
            {
                int count = int.Parse(commandInfo[1]);
                
                if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 0; i < count % numbers.Count; i++)
                {
                    string firstElement = numbers[0];

                    for (int j = 0; j < numbers.Count - 1; j++)
                    {
                        numbers[j] = numbers[j + 1];
                    }

                    numbers[numbers.Count - 1] = firstElement;
                }
            }
            else if (command == "rollRight")
            {
                int count = int.Parse(commandInfo[1]);

                if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 0; i < count % numbers.Count; i++)
                {
                    string lastElement = numbers[numbers.Count - 1];

                    for (int j = numbers.Count - 1; j > 0; j--)
                    {
                        numbers[j] = numbers[j - 1];
                    }

                    numbers[0] = lastElement;
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }
}
