using System;

public class CountTheIntegers
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int count = 0;
        int number = 0;

        while (true)
        {
            bool isParsed = int.TryParse(input, out number);

            if (isParsed)
            {
                count++;
            }
            else
            {
                Console.WriteLine(count);
                return;
            }

            input = Console.ReadLine();
        }           
    }
}
