using System;

public class TriangleOfNumbers
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int currentNumber = 1;

        for (int row = 1; row <= number; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(currentNumber + " ");
            }

            currentNumber++;
            Console.WriteLine();
        }
    }
}
