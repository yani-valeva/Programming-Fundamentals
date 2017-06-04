using System;

public class Transport
{
    public static void Main()
    {
        //int people = int.Parse(Console.ReadLine());
        //int capacity = 24;
        //int courses = (int)Math.Ceiling((double)people / capacity);
        //Console.WriteLine(courses);

        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            int currentNumber = i;
            int sum = 0;
            while (currentNumber > 0)
            {
                int digit = currentNumber % 10;
                currentNumber /= 10;
                sum += digit;
            }
            bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine("{0} -> {1}", i, isSpecial);
        }

    }
}
