using System;

public class HogwartsSorting
{
    public static void Main()
    {
        int studentsCount = int.Parse(Console.ReadLine());
        int gryffindorCount = 0;
        int slytherinCount = 0;
        int ravenclawCount = 0;
        int hufflepuffCount = 0;

        for (int i = 0; i < studentsCount; i++)
        {
            int sum = 0;
            string[] nameInfo = Console.ReadLine().Split(' ');
            string firstName = nameInfo[0];
            string secondName = nameInfo[1];
            string twoLetters = nameInfo[0][0].ToString() + nameInfo[1][0].ToString();

            for (int j = 0; j < firstName.Length; j++)
            {
                sum += firstName[j];
            }

            for (int k = 0; k < secondName.Length; k++)
            {
                sum += secondName[k];
            }

            int reminder = sum % 4;        

            if (reminder == 0)
            {
                Console.WriteLine($"Gryffindor {sum}{twoLetters}");
                gryffindorCount++;
            }
            else if (reminder == 1)
            {
                Console.WriteLine($"Slytherin {sum}{twoLetters}");
                slytherinCount++;
            }
            else if (reminder == 2)
            {
                Console.WriteLine($"Ravenclaw {sum}{twoLetters}");
                ravenclawCount++;
            }
            else if (reminder == 3)
            {
                Console.WriteLine($"Hufflepuff {sum}{twoLetters}");
                hufflepuffCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Gryffindor: {gryffindorCount}");
        Console.WriteLine($"Slytherin: {slytherinCount}");
        Console.WriteLine($"Ravenclaw: {ravenclawCount}");
        Console.WriteLine($"Hufflepuff: {hufflepuffCount}");
    }
}
