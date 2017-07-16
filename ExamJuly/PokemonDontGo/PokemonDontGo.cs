using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonDontGo
{
    public static void Main()
    {
        List<long> distance = Console.ReadLine().Split().Select(long.Parse).ToList();
        int index = int.Parse(Console.ReadLine());
        long sum = 0L;

        while (distance.Count > 0)
        {
            long removedElement = 0;
            if (index >= 0 && index <= distance.Count - 1)
            {
                removedElement = distance[index];
                sum += distance[index];
                distance.RemoveAt(index);
            }
            else if (index < 0)
            {
                long last = distance[distance.Count - 1];
                removedElement = distance[0];
                sum += distance[0];
                distance.RemoveAt(0);
                distance.Insert(0, last);
            }
            else if (index > distance.Count - 1)
            {
                removedElement = distance[distance.Count - 1];
                sum += distance[distance.Count - 1];
                distance.RemoveAt(distance.Count - 1);
                distance.Add(distance[0]);
            }

            for (int i = 0; i < distance.Count; i++)
            {
                if (distance[i] <= removedElement)
                {
                    distance[i] += removedElement;
                }
                else
                {
                    distance[i] -= removedElement;
                }
            }

            if (distance.Count < 1)
            {
                break;
            }
            index = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}
