using System;

public class DayOfWeek
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        if (number < 1 || number > 7)
        {
            Console.WriteLine("Invalid Day!");
        }
        else
        {
            Console.WriteLine(dayOfWeek[number - 1]);
        }
    }
}
