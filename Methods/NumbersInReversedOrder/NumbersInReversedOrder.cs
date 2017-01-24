using System;

class NumbersInReversedOrder
{
    public static void Main()
    {
        string number = Console.ReadLine();
        PrintNumberInReversedOrder(number);
    }

    public static void PrintNumberInReversedOrder(string number)
    {
        for (int i = number.Length - 1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }

        Console.WriteLine();
    }
}
