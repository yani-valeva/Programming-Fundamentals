using System;
using System.Collections.Generic;

public class MinerTask
{
    public static void Main()
    {
        string resourse = Console.ReadLine();
        Dictionary<string, long> resoursesAndQuantities = new Dictionary<string, long>();

        while (!resourse.Equals("stop"))
        {
            long quantity = long.Parse(Console.ReadLine());
            
            if (!resoursesAndQuantities.ContainsKey(resourse))
            {
                resoursesAndQuantities.Add(resourse, 0);
            }

            resoursesAndQuantities[resourse] += quantity;
            resourse = Console.ReadLine();
        }

        foreach (var key in resoursesAndQuantities)
        {
            Console.WriteLine($"{key.Key} -> {key.Value}");
        }
    }
}