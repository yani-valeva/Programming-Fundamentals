﻿using System;

public class TimeSinceBirthday
{
    public static void Main()
    {
        int years = int.Parse(Console.ReadLine());
        int days = years * 365;
        int hours = days * 24;
        int minutes = hours * 60;

        Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}
