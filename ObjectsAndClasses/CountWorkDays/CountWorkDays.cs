using System;
using System.Globalization;

public class CountWorkDays
{
    public static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        DateTime startDate = DateTime.ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(secondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        DateTime[] holidays = new DateTime[11];
        holidays[0] = Convert.ToDateTime("01-01-2017");
        holidays[1] = Convert.ToDateTime("03-03-2017");
        holidays[2] = Convert.ToDateTime("05-01-2017");
        holidays[3] = Convert.ToDateTime("05-06-2017");
        holidays[4] = Convert.ToDateTime("05-24-2017");
        holidays[5] = Convert.ToDateTime("09-06-2017");
        holidays[6] = Convert.ToDateTime("09-22-2017");
        holidays[7] = Convert.ToDateTime("11-01-2017");
        holidays[8] = Convert.ToDateTime("12-24-2017");
        holidays[9] = Convert.ToDateTime("12-25-2017");
        holidays[10] = Convert.ToDateTime("12-26-2017");

        int workingDaysCounter = 0;
        
        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday && !IsHoliday(holidays, date))
            {
                workingDaysCounter++;
            }
        }

        Console.WriteLine(workingDaysCounter);
    }

    public static bool IsHoliday(DateTime[] holidays, DateTime date)
    {
        bool isHoliday = false;

        for (int i = 0; i < 11; i++)
        {
            if (holidays[i].Month == date.Month && holidays[i].Day == date.Day)
            {
                isHoliday = true;
                break;
            }
        }

        return isHoliday;
    }
}
