using System;
using System.Numerics;

class FactorialTrailingZeroes
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        BigInteger factorial = GetFactorial(number);
        int zerosCount = CountTrailingZeros(factorial);

        Console.WriteLine(zerosCount);
    }

    public static BigInteger GetFactorial(int number)
    {
        BigInteger factorial = 1;

        for (int i = number; i >= 1; i--)
        {
            factorial *= i;
        }

        return factorial;        
    }

    public static int CountTrailingZeros(BigInteger factorial)
    {
        int count = 0;
        string numberAsString = factorial.ToString();

        for (int i = numberAsString.Length - 1; i >= 0; i--)
        {
            if (numberAsString[i] == '0')
            {
                count++;
            }
            else
            {
                break;
            }
        }

        return count;
    }
}
