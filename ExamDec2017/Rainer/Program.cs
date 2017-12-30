using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] raindropsInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> currentRaindrops = new List<int>();

        for (int i = 0; i < raindropsInfo.Length; i++)
        {
            currentRaindrops.Add(raindropsInfo[i] - 1);
        }

        int count = 0;
        int step = raindropsInfo.Length - 1;

        while (true)
        {
            if (currentRaindrops[step] == 0)
            {
                currentRaindrops.RemoveAt(currentRaindrops.Count - 1);
                Console.WriteLine(String.Join(" ", currentRaindrops));
                Console.WriteLine(count);
                return;
            }

            for (int i = 0; i < currentRaindrops.Count; i++)
            {
                if (currentRaindrops[i] == 0)
                {
                    currentRaindrops[i] = raindropsInfo[i];
                }
            }

            for (int i = 0; i < currentRaindrops.Count; i++)
            {
                currentRaindrops[i] -= 1;
            }

            step = int.Parse(Console.ReadLine());
            count++;
        }
    }
}