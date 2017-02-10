using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

public class StudentGroups
{
    public static void Main()
    {
        List<Group> groups = new List<Group>();
        List<Town> towns = new List<Town>();

        string input = Console.ReadLine();

        while (!input.Equals("End"))
        {
            string[] inputInfo = input.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
            string townName = inputInfo[0];
            string[] seatsInfo = inputInfo[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int seatsNumber = int.Parse(seatsInfo[0]);

            Town town = new Town();
            town.TownName = townName;
            town.SeatsCount = seatsNumber;
            town.Students = new List<Student>();
            towns.Add(town);

            input = Console.ReadLine();

            while (input.Contains('|'))
            {
                string[] studentsInfo = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string studentName = studentsInfo[0].Trim();
                string email = studentsInfo[1].Trim();
                string dateAsString = studentsInfo[2].Trim();
                DateTime registrationDate = DateTime.ParseExact(dateAsString, "d-MMM-yyyy", CultureInfo.InvariantCulture);

                Student student = new Student();
                student.StudentName = studentName;
                student.Email = email;
                student.RegistrationDate = registrationDate;
                town.Students.Add(student);

                input = Console.ReadLine();
            }
         
            Group group = new Group();
            group.Town = town;
            group.Students = town.Students;
            groups.Add(group);
        }

        int groupNumbers = 0;

        foreach (var item in groups)
        {
            int totalSeats = item.Town.SeatsCount;
            int totalStudents = item.Students.Count;
            groupNumbers = GetTotalNumberOfGroups(groupNumbers, totalSeats, totalStudents);
        }

        Console.WriteLine($"Created {groupNumbers} groups in {groups.Count} towns:");

        foreach (var town in groups.OrderBy(t => t.Town.TownName))
        {
            string currentTown = town.Town.TownName;
            int currentSeatsNumber = town.Town.SeatsCount;
            int currentStudentsNumber = town.Students.Count;
            int currentGroupsNumber = GetTotalNumberOfGroups(0, currentSeatsNumber, currentStudentsNumber);

            List<Student> students = towns.First(t => t.TownName == currentTown).Students;

            students = students.OrderBy(d => d.RegistrationDate).ThenBy(n => n.StudentName).ThenBy(e => e.Email).ToList();
            List<string> selectedEmails = new List<string>();
            int seatsCount = currentSeatsNumber;
            int studentsCount = currentStudentsNumber;

            foreach (var student in students)
            {
                string email = student.Email;
                selectedEmails.Add(email);
                seatsCount--;
                studentsCount--;

                if (seatsCount == 0 || studentsCount == 0)
                {
                    Console.WriteLine($"{currentTown}=> {string.Join(", ", selectedEmails)}");
                    seatsCount = currentSeatsNumber;
                    selectedEmails.Clear();
                }
            }
        }
    }

    public static int GetTotalNumberOfGroups(int groupNumbers, int totalSeats, int totalStudents)
    {
        groupNumbers += totalStudents / totalSeats;

        if (totalStudents % totalSeats != 0)
        {
            groupNumbers++;
        }

        return groupNumbers;
    }
}
