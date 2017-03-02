using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationAggregation
{
    public static void Main()
    {
        SortedDictionary<string, Dictionary<string, long>> countriesAndcities = new SortedDictionary<string, Dictionary<string, long>>();
        SortedDictionary<string, int> countryAndCityCounts = new SortedDictionary<string, int>();
        string input = Console.ReadLine();
        char[] prohibitedSymbols = { '@', '#', '$', '&', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        while (!input.Equals("stop"))
        {
            string[] inputInfo = input.Split('\\');
            bool isCountry = false;
            string countryName = string.Empty;
            string city = string.Empty;
            long population = long.Parse(inputInfo[2]);
            string firstClearedElement = GetClearedElements(prohibitedSymbols, inputInfo[0]);
            
            if (Char.IsUpper(firstClearedElement[0]))
            {
                countryName = firstClearedElement;
                isCountry = true;
            }
            else
            {
                city = firstClearedElement;
            }

            string secondClearedElement = GetClearedElements(prohibitedSymbols, inputInfo[1]);

            if (isCountry)
            {
                city = secondClearedElement;
            }
            else
            {
                countryName = secondClearedElement;
            }

            if (!countriesAndcities.ContainsKey(countryName) && !countryAndCityCounts.ContainsKey(countryName))
            {
                countriesAndcities.Add(countryName, new Dictionary<string, long>());
                countryAndCityCounts.Add(countryName, 0);
            }
            if (!countriesAndcities[countryName].ContainsKey(city))
            {
                countriesAndcities[countryName].Add(city, 0L);
            }

            countriesAndcities[countryName][city] = population;
            countryAndCityCounts[countryName] += 1;
            input = Console.ReadLine();
        }

        Dictionary<string, long> selectedCities = new Dictionary<string, long>();

        foreach (var country in countriesAndcities)
        {
            Console.WriteLine($"{country.Key} -> {countryAndCityCounts[country.Key]}");

            foreach (var city in countriesAndcities[country.Key])
            {
                selectedCities.Add(city.Key, city.Value);
            }
        }

        int count = 3;

        foreach (var city in selectedCities.OrderByDescending(p => p.Value))
        {
            Console.WriteLine($"{city.Key} -> {city.Value}");
            count--;

            if (count == 0)
            {
                break;
            }
        }
    }

    public static string GetClearedElements(char[] prohibitedSymbols, string inputInfo)
    {
        for (int i = 0; i < prohibitedSymbols.Length; i++)
        {
            for (int j = 0; j < inputInfo.Length; j++)
            {
                if (prohibitedSymbols[i] == inputInfo[j])
                {
                    inputInfo = inputInfo.Remove(j, 1);
                    j--;
                }
            }
        }

        return inputInfo;
    }
}
