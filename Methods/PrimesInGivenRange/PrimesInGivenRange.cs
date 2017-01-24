using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    public static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        List<int> primes = FindPRimesInRange(startNumber, endNumber);

        Console.WriteLine(string.Join(", ", primes));
    }

    public static List<int> FindPRimesInRange(int startNumber, int endNumber)
    {
        List<int> primes = new List<int>();

        for (int currentNumber = startNumber; currentNumber <= endNumber; currentNumber++)
        {
            bool isPrime = true;

            if (currentNumber < 2)
            {
                isPrime = false;
            }

            for (int divisor = 2; divisor <= Math.Sqrt(currentNumber); divisor++)
            {
                if (currentNumber % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primes.Add(currentNumber);
            }
        }
        return primes;
    }
}
