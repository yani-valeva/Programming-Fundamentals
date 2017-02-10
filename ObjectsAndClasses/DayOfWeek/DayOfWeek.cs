using System;
using System.Globalization;

public class DayOfWeek
{
    public static void Main()
    {
        string input = Console.ReadLine();
        DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

        string[] inputInfo = input.Split('-');
        int day = int.Parse(inputInfo[0]);
        int month = int.Parse(inputInfo[1]);
        int year = int.Parse(inputInfo[2]);

        DateTime currentDate = new DateTime(year, month, day);

        Console.WriteLine(currentDate.DayOfWeek);
    }
}
