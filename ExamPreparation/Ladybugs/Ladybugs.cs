using System;
using System.Collections.Generic;
using System.Linq;

public class Ladybugs
{
    public static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        List<int> field = new List<int>();

        for (int i = 0; i < fieldSize; i++)
        {
            field.Add(0);
        }

        long[] indexes = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        string input = Console.ReadLine();

        for (int i = 0; i < indexes.Length; i++)
        {
            if (indexes[i] >= 0 && indexes[i] < field.Count)
            {
                field[(int)indexes[i]] = 1;
            }
        }

        while (!input.Equals("end"))
        {
            string[] commandInfo = input.Split(' ');
            long initialPosition = long.Parse(commandInfo[0]);
            string command = commandInfo[1];
            long length = long.Parse(commandInfo[2]);
            ChangePosition(field, initialPosition, command, length);
            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }

    public static void ChangePosition(List<int> field, long initialPosition, string command, long length)
    {
        switch (command)
        {
            case "left":
                MoveLeft(field, initialPosition, length);
                break;

            case "right":
                MoveRight(field, initialPosition, length);
                break;
        }
    }

    public static void MoveRight(List<int> field, long initialPosition, long length)
    {
        long newPosition = initialPosition + length;

        if (initialPosition >= 0 && initialPosition < field.Count && field[(int)initialPosition] == 1)
        {
            field[(int)initialPosition] = 0;

            if (newPosition >= 0 && newPosition < field.Count && field[(int)newPosition] == 0)
            {
                field[(int)newPosition] = 1;
            }
            else if (newPosition >= 0 && newPosition < field.Count && field[(int)newPosition] == 1)
            {
                newPosition += length;

                while (newPosition < field.Count)
                {
                    if (field[(int)newPosition] == 0)
                    {
                        field[(int)newPosition] = 1;
                        break;
                    }

                    newPosition += length;
                }
            }
        }
    }

    public static void MoveLeft(List<int> field, long initialPosition, long length)
    {
        long newPosition = initialPosition - length;

        if (initialPosition >= 0 && initialPosition < field.Count && field[(int)initialPosition] == 1)
        {
            field[(int)initialPosition] = 0;

            if (newPosition >= 0 && newPosition < field.Count && field[(int)newPosition] == 0)
            {
                field[(int)newPosition] = 1;
            }
            else if (newPosition >= 0 && newPosition < field.Count && field[(int)newPosition] == 1)
            {
                newPosition -= length;

                while (newPosition < field.Count)
                {
                    if (field[(int)newPosition] == 0)
                    {
                        field[(int)newPosition] = 1;
                        break;
                    }

                    newPosition -= length;
                }
            }
        }
    }
}

