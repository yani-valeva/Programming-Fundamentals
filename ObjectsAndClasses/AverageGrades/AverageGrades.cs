using System;
using System.Collections.Generic;
using System.Linq;

public class AverageGrades
{
    public static void Main()
    {
        List<Student> students = new List<Student>();
        int numberOfStudents = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStudents; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            Student student = new Student();
            student.Name = input[0];
            List<double> grades = new List<double>();

            for (int j = 1; j < input.Length; j++)
            {
                grades.Add(double.Parse(input[j]));
            }

            student.Grades = grades;
            students.Add(student);
        }

        foreach (var student in students.Where(a => a.AverageGrade >= 5).OrderBy(n => n.Name).ThenByDescending(a => a.AverageGrade))
        {
            string name = student.Name;
            double average = student.AverageGrade;

            Console.WriteLine($"{name} -> {average:f2}");
        }
    }
}