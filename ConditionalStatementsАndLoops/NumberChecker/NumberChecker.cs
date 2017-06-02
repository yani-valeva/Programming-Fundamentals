using System;

public class NumberChecker
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int number = 0;
        bool isNumber = int.TryParse(input, out number);

        if (isNumber)
        {
            Console.WriteLine("It is a number.");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
