using System;
using System.Collections.Generic;
using System.Linq;

public class Numbers
{
    public static void Main()
    {
        long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        List<long> selectedNumbers = new List<long>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers.Average())
            {
                selectedNumbers.Add(numbers[i]);
            }
        }
        
        long selectedNumbersCount = selectedNumbers.Count;
        long count = 0;

        if (selectedNumbersCount >= 5)
        {
            count = 5;
        }
        else
        {
            count = selectedNumbersCount;
        }
        if (selectedNumbersCount == 0)
        {
            Console.WriteLine("No");
            return;
        }
       
        foreach (var number in selectedNumbers.OrderByDescending(n => n))
        {
            if (count == 1)
            {
                Console.WriteLine(number);
                break;
            }
            else
            {
                Console.Write(number + " ");               
                count--;
            }
        }
    }
}
