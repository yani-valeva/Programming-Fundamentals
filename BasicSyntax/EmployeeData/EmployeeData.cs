﻿using System;

public class EmployeeData
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int employeeId = int.Parse(Console.ReadLine());
        decimal salary = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Employee ID: {employeeId:D8}");
        Console.WriteLine($"Salary: {salary:f2}");
    }
}
