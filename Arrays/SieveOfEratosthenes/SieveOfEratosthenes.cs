using System;

public class SieveOfEratosthenes
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool[] isPrime = new bool[number + 1];

        for (int i = 0; i < isPrime.Length; i++)
        {
            isPrime[i] = true;
        }

        isPrime[0] = false;
        isPrime[1] = false;

        for (int i = 0; i < isPrime.Length; i++)
        {
            if (isPrime[i] == true)
            {
                Console.Write(i + " ");

                int position = i * i;

                for (int j = i + 1; j < isPrime.Length; j++)
                {
                    
                    if (j == position)
                    {
                        isPrime[j] = false;
                        position += i;
                    }
                }
            }
        }

        Console.WriteLine();
    }
}
