using System;

class DrawFilledSquare
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        PrintHeaderAndFooterRow(number);
        PrintMiddleRows(number);
        PrintHeaderAndFooterRow(number);
    }

    public static void PrintHeaderAndFooterRow(int number)
    {
        Console.WriteLine(new string('-', 2 * number));
    }

    public static void PrintMiddleRows(int number)
    {
        for (int i = 0; i < number - 2; i++)
        {
            Console.Write("-");
            for (int j = 0; j < number - 1; j++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
