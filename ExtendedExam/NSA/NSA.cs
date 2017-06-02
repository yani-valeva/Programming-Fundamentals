using System;
using System.Collections.Generic;
using System.Linq;

class NSA
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, long>> countryData = new Dictionary<string, Dictionary<string, long>>();
        string[] input = Console.ReadLine().Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        while (!input[0].Equals("quit"))
        {
            string countryName = input[0];
            string spyName = input[1];
            long daysInService = long.Parse(input[2]);

            if (!countryData.ContainsKey(countryName))
            {
                countryData.Add(countryName, new Dictionary<string, long>());
            }

            if (!countryData[countryName].ContainsKey(spyName))
            {
                countryData[countryName].Add(spyName, 0L);
            }

            countryData[countryName][spyName] = daysInService;

            input = Console.ReadLine().Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var data in countryData.OrderByDescending(c => c.Value.Values.Count()))
        {
            string currentCountry = data.Key;
            Console.WriteLine($"Country: {currentCountry}");
            var selected = countryData[currentCountry];
            foreach (var key in selected.OrderByDescending(d => d.Value))
            {
                Console.WriteLine($"**{key.Key} : {key.Value}");
            }
        }
    }
}
