using System;
using System.Collections.Generic;
using System.Linq;

public class HornetAssault
{
    public static void Main()
    {
        long[] beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
        long power = 0L;
        List<long> aliveBeehives = new List<long>();
        bool hasAliveBeehives = false;

        for (int i = 0; i < hornets.Count; i++)
        {
            power += hornets[i];
        }

        for (int i = 0; i < beehives.Length; i++)
        {
            long amountOfBees = beehives[i];

            if (power > amountOfBees)
            {
                continue;
            }
            else if (power < amountOfBees)
            {
                try
                {
                    aliveBeehives.Add(amountOfBees - power);
                    hasAliveBeehives = true;
                    long currentPower = hornets[0];
                    power -= currentPower;
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }
                }
                catch (Exception)
                {


                }
            }
            else
            {
                try
                {
                    long currentPower = hornets[0];
                    power -= currentPower;
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }
                }
                catch (Exception)
                {


                }
            }
        }

        if (hasAliveBeehives)
        {
            Console.WriteLine(string.Join(" ", aliveBeehives));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets));
        }
    }
}
