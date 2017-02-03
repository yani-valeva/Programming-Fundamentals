using System;
using System.Collections.Generic;
using System.Linq;

public class LegendaryFarming
{
    public static void Main()
    {
        Dictionary<string, int> keyMatereals = new Dictionary<string, int>();
        SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();
        keyMatereals.Add("shards", 0);
        keyMatereals.Add("fragments", 0);
        keyMatereals.Add("motes", 0);
        string material = string.Empty;
        bool isReached = false;

        while (!isReached)
        {
            string[] input = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length - 1; i++)
            {
                int quantity = int.Parse(input[i]);
                material = input[i + 1];

                if (keyMatereals.ContainsKey(material))
                {
                    keyMatereals[material] += quantity;
                }
                else
                {
                    if (!junkMaterials.ContainsKey(material))
                    {
                        junkMaterials.Add(material, 0);
                    }

                    junkMaterials[material] += quantity;
                }

                if (keyMatereals.ContainsKey(material) && keyMatereals[material] >= 250)
                {
                    keyMatereals[material] -= 250;
                    isReached = true;
                    break;
                }

                i++;
            }
        }

        if (material.Equals("shards"))
        {
            Console.WriteLine("Shadowmourne obtained!" );
        }
        else if (material.Equals("fragments"))
        {
            Console.WriteLine("Valanyr obtained!");
        }
        else if (material.Equals("motes"))
        {
            Console.WriteLine("Dragonwrath obtained!");
        }

        foreach (var key in keyMatereals.OrderByDescending(m => m.Value).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{key.Key}: {key.Value}");
        }

        foreach (var key in junkMaterials)
        {
            Console.WriteLine($"{key.Key}: {key.Value}");
        }
    }
}
