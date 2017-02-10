using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class MentorGroup
{
    public static void Main()
    {
        string input = Console.ReadLine();
        List<Student> students = new List<Student>();

        while (!input.Equals("end of dates"))
        {
            string[] useramesInfo = input.Split(' ');
            string userName = useramesInfo[0];
            if (!students.Any(s => s.Name == userName))
            {
                Student student = new Student();
                student.Name = userName;
                student.Comments = new List<string>();
                student.AttendanceDate = new List<DateTime>();
                var attendanceDate = GetAttendanceDate(useramesInfo, student);
                students.Add(student);
            }
            else
            {
                Student student = students.First(s => s.Name == userName);
                var attendanceDate = GetAttendanceDate(useramesInfo, student);               
            }

            input = Console.ReadLine();
        }

        string studentsAndCommentsInfo = Console.ReadLine();

        while (!studentsAndCommentsInfo.Equals("end of comments"))
        {
            string[] studentsAndComments = studentsAndCommentsInfo.Split('-');
            string name = studentsAndComments[0];
            string comment = studentsAndComments[1];

            foreach (var student in students)
            {
                if (student.Name == name)
                {
                    student.Comments.Add(comment);
                    break;
                }
            }
            
            studentsAndCommentsInfo = Console.ReadLine();
        }

        foreach (var student in students.OrderBy(s => s.Name))
        {
            string name = student.Name;

            Console.WriteLine(name);
            Console.WriteLine("Comments:");

            var currentComments = student.Comments;

            foreach (var comment in currentComments)
            {
                Console.WriteLine($"- {comment}");
            }

            Console.WriteLine($"Dates attended:");

            var currentAttendanceDate = student.AttendanceDate;

            foreach (var date in currentAttendanceDate.OrderBy(d => d.Date))
            {
                var currentDate = date.Date.ToString("dd/MM/yyyy");
                Console.WriteLine($"-- {currentDate}");
            }
        }
    }

    public static Student GetAttendanceDate(string[] useramesInfo, Student student)
    {
        if (useramesInfo.Length > 1)
        {
            string[] attendanceDateInfo = useramesInfo[1].Split(',');

            for (int i = 0; i < attendanceDateInfo.Length; i++)
            {
                DateTime attendanceDate = DateTime.ParseExact(attendanceDateInfo[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                student.AttendanceDate.Add(attendanceDate);
            }
        }

        return student;
    }
}