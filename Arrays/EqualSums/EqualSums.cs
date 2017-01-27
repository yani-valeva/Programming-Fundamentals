using System;
using System.Linq;

public class EqualSums
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        bool isFound = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = 0; j < i; j++)
            {
                leftSum += numbers[j];
            }

            for (int j = i + 1; j < numbers.Length; j++)
            {
                rightSum += numbers[j];
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                isFound = true;
                break;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("no");
        }
    }
}
