using System;

class FibonacciNumbers
{
    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long fibonacii = CalculateFibonacciNumbers(number);

        Console.WriteLine(fibonacii);
    }

    public static long CalculateFibonacciNumbers(long number)
    {
        long previousFibonacci = 1;
        long currentFibonacii = 1;

        for (int i = 2; i <= number; i++)
        {
            long nextFibonacci = previousFibonacci + currentFibonacii;
            previousFibonacci = currentFibonacii;
            currentFibonacii = nextFibonacci;
        }
        return currentFibonacii;
    }
}
