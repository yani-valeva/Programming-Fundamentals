using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayManipulator
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        string input = Console.ReadLine();

        while (!input.Equals("end"))
        {
            string[] command = input.Split(' ');

            if (command[0] == "exchange")
            {
                long index = long.Parse(command[1]);

                if (index < 0 || index >= numbers.Count)
                {
                    Console.WriteLine("Invalid index");
                    input = Console.ReadLine();
                    continue;
                }

                var temporary = numbers.Take((int)index + 1).ToArray();
                numbers.RemoveRange(0, (int)index + 1);
               
                for (int i = 0; i < temporary.Length; i++)
                {
                    numbers.Add(temporary[i]);
                }
            }
            else if (command[0] == "max")
            {
                int current = -1;
                int max = -1;
                int index = -1;

                if (command[1] == "odd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];

                        if (number % 2 != 0)
                        {
                            current = number;

                            if (max <= current)
                            {
                                max = current;
                                index = i;
                            }
                        }
                    }

                    if (index >= 0)
                    {
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (command[1] == "even")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];

                        if (number % 2 == 0)
                        {
                            current = number;

                            if (max <= current)
                            {
                                max = current;
                                index = i;
                            }
                        }
                    }

                    if (index >= 0)
                    {
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
            }
            else if (command[0] == "min")
            {
                int current = -1;
                int min = int.MaxValue;
                int index = -1;

                if (command[1] == "odd")
                {

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];

                        if (number % 2 != 0)
                        {
                            current = number;

                            if (min >= current)
                            {
                                min = current;
                                index = i;
                            }
                        }
                    }

                    if (index >= 0)
                    {
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (command[1] == "even")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];

                        if (number % 2 == 0)
                        {
                            current = number;

                            if (min >= current)
                            {
                                min = current;
                                index = i;
                            }
                        }
                    }

                    if (index >= 0)
                    {
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
            }
            else if (command[0] == "first")
            {
                long count = long.Parse(command[1]);

                if (count > numbers.Count)
                {
                    Console.WriteLine("Invalid count");
                    input = Console.ReadLine();
                    continue;
                }
                if (command[2] == "odd")
                {
                    List<int> collectedNumbers = new List<int>();
                    int index = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];

                        if (number % 2 != 0)
                        {
                            collectedNumbers.Add(number);
                            index++;

                            if (index == count)
                            {
                                break;
                            }
                        }
                    }

                    Console.WriteLine($"[{string.Join(", ", collectedNumbers)}]");
                }
                else if (command[2] == "even")
                {
                    List<int> collectedNumbers = new List<int>();
                    int index = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];

                        if (number % 2 == 0)
                        {
                            collectedNumbers.Add(number);
                            index++;

                            if (index == count)
                            {
                                break;
                            }
                        }
                    }

                    Console.WriteLine($"[{string.Join(", ", collectedNumbers)}]");
                }
            }
            else if (command[0] == "last")
            {
                long count = long.Parse(command[1]);

                if (count > numbers.Count)
                {
                    Console.WriteLine("Invalid count");
                    input = Console.ReadLine();
                    continue;
                }

                numbers.Reverse();

                if (command[2] == "odd")
                {                  
                    List<int> collectedNumbers = new List<int>();
                    int index = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];

                        if (number % 2 != 0)
                        {
                            collectedNumbers.Add(number);
                            index++;

                            if (index == count)
                            {
                                break;
                            }
                        }
                    }

                    collectedNumbers.Reverse();
                    Console.WriteLine($"[{string.Join(", ", collectedNumbers)}]");
                    numbers.Reverse();
                }
                else if (command[2] == "even")
                {
                    List<int> collectedNumbers = new List<int>();
                    int index = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];

                        if (number % 2 == 0)
                        {
                            collectedNumbers.Add(number);
                            index++;

                            if (index == count)
                            {
                                break;
                            }
                        }
                    }

                    collectedNumbers.Reverse();
                    Console.WriteLine($"[{string.Join(", ", collectedNumbers)}]");
                    numbers.Reverse();
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");       
    }
}

